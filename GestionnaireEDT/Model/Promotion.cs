using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireEDT.Model
{
    class Promotion : Destinataire
    {
        private string nom;
        private DateTime dateDebut;
        private DateTime dateFin;
        private List<Eleve> eleves;
        private Formation formations;
        private List<Session> sessions;





        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public DateTime Datedebut
        {
            get { return dateDebut; }
            set { dateDebut = value; }
        }

        public DateTime DateFin
        {
            get { return dateFin; }
            set { dateFin = value; }
        }

        public List<Session> Sessions
        {
            get { return sessions; }
            set { sessions = value; }
        }


        public bool estDisponible(DateTime dateDebutPlage, DateTime dateFinPlage)
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
            return this.Sessions;
        }

        public List<Eleve> Eleves
        {
            get { return eleves; }
            set
            {

                if(value.Count > 24)
                {
                    throw new EffectifExeption("il y plus de 24 élèves dans le promotion");
                }
                eleves = value;
            }


        }

        public Formation Formations
        {
            get { return formations; }
            set { formations = value; }
        }

    }
}
