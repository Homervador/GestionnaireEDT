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

        public Salle(string nom, int capacite)
        {
            if(nom == null || capacite == 0)
            {
                throw new ChampException("Les champs de Salle n'ont pas tous été renseignés");
            }
            this.nom = nom;
            this.capacite = capacite;
        }
        public bool estDisponible(DateTime dateDebutPlage, DateTime dateFinPlage)
        {
            foreach (Session session in Sessions)
            {
                if (!session.estHorsDeLaPlage(dateDebutPlage, dateFinPlage))
                {
                    return false;
                }
            }

            return true;
        }

        public List<Session> getSession()
        {
            return this.Sessions;
        }
    }
}
