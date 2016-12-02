using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireEDT.Model
{
    class Formateur : Destinataire
    {
        private string nom;
        private string prenom;
        private string mail;
        private string telephone;
        private List<Matiere> matiere;
        private List<Session> sessions;

        public List<Session> Sessions
        {
            get { return sessions; }
            set { sessions = value; }
        }
        
        public string Nom
        {
            get { return nom; }
            set
            {
                if( value == null)
                {
                    throw new ChampException("Tous les champs du formateur ne sont pas rempli");
                }
                nom = value;
            }
        }

        public string Prenom
        {
            get { return prenom; }
            set
            {
                if (value == null)
                {
                    throw new ChampException("Tous les champs du formateur ne sont pas rempli");
                }
                prenom = value;
            }
        }
        
        public string Mail
        {
            get { return mail; }
            set
            {
                if (value == null)
                {
                    throw new ChampException("Tous les champs du formateur ne sont pas rempli");
                }
                mail = value;
            }
        }
        
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        public Formateur(string nom, string prenom, string mail, string telephone)
        {
            if(nom == null || prenom == null || mail == null)
            {
                throw new ChampException("Tous les champs du formateur ne sont pas rempli");
            }
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.telephone = telephone;
        }


        public float heuresTravaillees (DateTime debutPeriode, DateTime finPeriode)
        {
            float heuresTravaillees;
            heuresTravaillees = 0;
            TimeSpan tempsDeTravail = new TimeSpan(0, 0, 0);

            foreach (Session session in Sessions)
            {
                if (debutPeriode < session.DateFin && finPeriode > session.DateDebut)
                {
                    tempsDeTravail += session.DateFin - session.DateDebut;
                }
            }
            heuresTravaillees = Convert.ToSingle(tempsDeTravail.TotalHours);
            return heuresTravaillees;
        }

        public bool estDisponible (DateTime dateDebutPlage, DateTime dateFinPlage)
        {

            foreach (Session session in Sessions)
            {
                if (!session.estHorsDeLaPlage(dateDebutPlage, dateFinPlage))
                {
                    return false;
                }
            }

            return true;
        }

        public List<Session> getSession()
        {
            return this.Sessions;
        }


        public List<Matiere> Matiere
        {
            get { return matiere; }
            set { matiere = value; }
        }
    }
}
