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
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        public float heuresTravaillees (DateTime debutPeriode, DateTime finPeriode)
        {

        }

        public bool estDisponible (DateTime dateDebutPlage, DateTime dateFinPlage)
        {
            foreach (Session session in Sessions)
            {
                if (dateDebutPlage < session.DateFin && dateFinPlage > session.DateDebut)
                {
                    return false;
                }
            }

            return true;
        }

        public List<Session> getSession()
        {
            return new List<Session>();
        }


        public List<Matiere> Matiere
        {
            get { return matiere; }
            set { matiere = value; }
        }
    }
}
