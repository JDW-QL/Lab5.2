using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._2
{
    class CannotMakeUpHisOrHerMind : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            var rand = new Random(0);
            switch (rand.Next(0, 3))
            {
                case 1:
                    return Roshambo.Rock;
                case 2:
                    return Roshambo.Paper;
                default:
                    return Roshambo.Scissors;
            }
        }
    }
}
