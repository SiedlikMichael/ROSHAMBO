using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSHAMBO_LAB
{
    internal class RandomPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            Random random = new Random();
            int ran = random.Next(0, 3);
            Roshambo roshambo = (Roshambo) ran;
            return roshambo;
        }
    }
}
