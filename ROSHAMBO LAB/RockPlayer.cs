using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSHAMBO_LAB
{
    internal class RockPlayer : Player
    {
        public RockPlayer()
        {
            Name = "RockPlayer";

        }
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
    }

}

