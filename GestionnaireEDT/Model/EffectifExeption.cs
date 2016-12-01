using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireEDT.Model
{
    class EffectifExeption:Exception
    {
        public EffectifExeption (string message) : base (message)
        {

        }
    }
}
