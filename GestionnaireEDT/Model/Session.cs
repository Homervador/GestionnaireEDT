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

    }
}
