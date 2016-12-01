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

        public bool estDisponible(DateTime dateDebut, DateTime datefin)
        {
            return true;
        }

        public List<Session> getSession()
        {

        }
    }
}
