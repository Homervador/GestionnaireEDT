using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireEDT.Model
{
    class Eleve
    {
        private string nom;
        private string prénom;
        private string mail;
        private List<Absence> absences;
        private Promotion promotion;
        


        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prénom; }
            set { prénom = value; }
        }

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public int getNbAbsences (DateTime dateDebut, DateTime dateFin)
        {
            int compeurtAbs;
            compeurtAbs = 0;

            if (absences != null)

            {
                foreach (Absence absence in absences)
                {
                    if (absence.Session.DateDebut > dateDebut && absence.Session.DateFin < dateFin)
                    {
                        compeurtAbs++;
                    }
                }
            }

            return compeurtAbs;

        }
        public List<Absence> Absences
        {
            get { return absences; }
            set { absences = value; }
        }
        
        public Promotion Promotion
        {
            get { return promotion; }
            set { promotion = value; }
        }



    }
}
