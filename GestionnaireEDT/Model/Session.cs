using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireEDT.Model
{
    class Session
    {
        private DateTime dateDebut;
        private DateTime dateFin;
        private Promotion promotion;
        private Matiere matiere;
        private Formateur formateur;
        private Salle salle;
        

        public Promotion Promotion
        {
            get { return promotion; }
            set { promotion = value; }
        }

        public Matiere Matiere
        {
            get { return matiere; }
            set { matiere = value; }
        }

        public Formateur Formateur
        {
            get { return formateur; }
            set { formateur = value; }
        }

        public Salle Salle
        {
            get { return salle; }
            set { salle = value; }
        }


        public DateTime DateDebut
        {
            get { return dateDebut; }
            set
            {
                if (DateFin <= value)
                {
                    throw new DateException("Impossible de mettre une datte de début après une date de fin");
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

        public Session(DateTime dateDebut, DateTime dateFin)
        {


            if (dateDebut >= dateFin)
            {
                throw new DateException("L'heure de début ne peut pas être après l'heure de fin");
            }

            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
        }

        public bool estHorsDeLaPlage(DateTime dateDebutPlage, DateTime dateFinPlage)
        {
            return (dateDebutPlage > this.DateFin || dateFinPlage < this.DateDebut);
        }
    }
}
