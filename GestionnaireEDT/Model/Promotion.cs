using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireEDT.Model
{
    class Promotion : Destinataire
    {
        private string nom;
        private DateTime dateDebut;
        private DateTime dateFin;
        private List<Eleve> eleves;
        private Formation formations;
        private List<Session> sessions;





        public string Nom
        {
            get { return nom; }
            set { nom = value; }
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
                    throw new DateException("Impossible de mettre une datte de début après une date de fin");
                }
                dateFin = value;
            }
        }

        public List<Session> Sessions
        {
            get { return sessions; }
            set { sessions = value; }
        }

        public Promotion (string nom, DateTime dateDebut, DateTime dateFin)
        {
            if (nom == null)
            {
                throw new ChampException("aucun nom n'a été donner à la promotion");
            }

            if (dateDebut >= dateFin)
            {
                throw new DateException("L'heure de début ne peut pas être après l'heure de fin");
            }

            this.nom = nom;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;

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

        public List<Eleve> Eleves
        {
            get { return eleves; }
            set
            {

                if(value.Count > 24)
                {
                    throw new EffectifExeption("il y plus de 24 élèves dans le promotion");
                }
                eleves = value;
            }


        }

        public Formation Formations
        {
            get { return formations; }
            set { formations = value; }
        }

    }
}
