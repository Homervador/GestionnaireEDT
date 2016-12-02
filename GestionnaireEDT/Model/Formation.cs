using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireEDT.Model
{
    class Formation
    {
        private string nom;
        private float nbHeuresTotal;
        private List<Promotion> promotion;
        private List<Matiere> matiere;
        

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public float NbHeuresTotal
        {
            get { return nbHeuresTotal; }
            set { nbHeuresTotal = value; }
        }

        public Formation(string nom, float nbHeuresTotal)
        {
            if(nom == null || nbHeuresTotal == 0)
            {
                throw new ChampException("Les champs de formation n'ont pas été rempli");
            }
            this.nom = nom;
            this.nbHeuresTotal = nbHeuresTotal;
        }
        public List<Promotion> Promotion
        {
            get { return promotion; }
            set { promotion = value; }
        }

        public List<Matiere> Matiere
        {
            get { return matiere; }
            set { matiere = value; }
        }

    }
}
