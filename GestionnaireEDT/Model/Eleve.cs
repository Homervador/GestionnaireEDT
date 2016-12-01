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
        private List<Absence> absence;
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
            
        }
        public List<Absence> Absence
        {
            get { return absence; }
            set { absence = value; }
        }
        
        public Promotion Promotion
        {
            get { return promotion; }
            set { promotion = value; }
        }



    }
}
