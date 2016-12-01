using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireEDT.Model
{
    class Absence
    {
        private Eleve eleve;
        private Session session;

        public Eleve Eleve
        {
            get { return eleve;; }
            set { eleve = value; }
        }
        
        public Session Session
        {
            get { return session;; }
            set { session = value; }
        }




    }
}
