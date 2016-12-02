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
            set
            {
                if (DateFin <= value)
                {
                    throw new DateException("Impossible de mettre une datte de fin avant une datte de début");
                }
                dateDebut = value;
            }
        }

        public DateTime DateFin
        {
            get { return dateFin; }
            set
            {
                if (DateDebut >= value)
                {
                    throw new DateException("Impossible de mettre une datte de fin avant une datte de début");
                }
                dateFin = value;
            }
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

        public  EmploiDuTemps(DateTime dateDebut, DateTime dateFin)
        {


            if (dateDebut >= dateFin)
            {
                throw new DateException("L'heure de début ne peut pas être après l'heure de fin");
            }

            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
        }

    }
}
