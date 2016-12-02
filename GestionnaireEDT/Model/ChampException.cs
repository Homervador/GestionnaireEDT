using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireEDT.Model
{
    class ChampException:Exception
    {
        public ChampException(String message) : base(message)
        {

        }
    }
}
