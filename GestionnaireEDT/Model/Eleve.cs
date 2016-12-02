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
        private string prenom;
        private string mail;
        private List<Absence> absences;
        private Promotion promotion;
        


        public string Nom
        {
            get { return nom; }
            set
            {
                if (value == null)
                {
                    throw new ChampException("Tous les champs de l'élève ne sont pas rempli");
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
                    throw new ChampException("Tous les champs de l'élève ne sont pas rempli");
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
                    throw new ChampException("Tous les champs de l'élève ne sont pas rempli");
                }
                mail = value;
            }
        }

        public Eleve (string nom, string prenom, string mail)
        {
            if (nom == null || prenom == null || mail == null)
            {
                throw new ChampException("Tous les champs de l'élève ne sont pas rempli");
            }
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
        }

        public int getNbAbsences (DateTime dateDebut, DateTime dateFin)
        {
            int compeurtAbs;
            compeurtAbs = 0;

            if (absences != null)

            {
                foreach (Absence absence in absences)
                {
                    if (absence.Session.estHorsDeLaPlage ( dateDebut, dateFin))

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
