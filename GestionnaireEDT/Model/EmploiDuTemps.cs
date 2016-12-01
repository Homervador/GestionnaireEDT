using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireEDT.Model
{
    class EmploiDuTemps
    {
        private DateTime dateDebut;
        private DateTime dateFin;
        private List<Session> session;
        private Destinataire destinataire;



        public DateTime DateDebut
        {
            get { return dateDebut; }
            set { dateDebut = value; }
        }

        public DateTime DateFin
        {
            get { return dateFin; }
            set { dateFin = value; }
        }
        
        public List<Session> Session
        {
            get { return session; }
            set { session = value; }
        }

        public Destinataire Destinataire
        {
            get { return destinataire; }
            set { destinataire = value; }
        }

    }
}
