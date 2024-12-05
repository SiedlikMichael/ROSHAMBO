using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSHAMBO_LAB
{
    internal class HumanPlayer : Player 
    {
        public int selected {  get; set; }
        public override Roshambo GenerateRoshambo()
        {
            Roshambo roshambo = (Roshambo) selected; 
            switch (roshambo)
            {
                case Roshambo.Rock:
                    return Roshambo.Rock;
                case Roshambo.Paper:
                    return Roshambo.Paper;
                case Roshambo.Scissors:
                    return Roshambo.Scissors;
               
                default:
                    throw new ArgumentException("Invalid");

            }

        }
    }
}
