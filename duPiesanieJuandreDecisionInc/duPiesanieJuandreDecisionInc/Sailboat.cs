using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duPiesanieJuandreDecisionInc
{
    class Sailboat : Boat
    {
        public Sailboat()
        {
            Speed = 15;
        }
        public override string ToString()
        {
            return string.Format("Sailboat");
        }
    }
}
