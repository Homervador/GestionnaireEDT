using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireEDT.Model
{
    class Salle : Destinataire
    {
        private string nom;
        private int capacite;
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

        public int Capacite
        {
            get { return capacite; }
            set { capacite = value; }
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

        }
    }
}
