using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duPiesanieJuandreDecisionInc
{
    class Speedboat : Boat
    {
        public Speedboat()
        {
            Speed = 30;
        }
        public override string ToString()
        {
            return string.Format("Speedboat");
        }
    }
}
