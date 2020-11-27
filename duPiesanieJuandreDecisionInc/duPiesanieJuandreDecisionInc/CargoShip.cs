using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duPiesanieJuandreDecisionInc
{
    class CargoShip : Boat
    {
        public CargoShip()
        {
            Speed = 5;
        }
        public override string ToString()
        {
            return string.Format("CargoShip");
        }
    }
}
