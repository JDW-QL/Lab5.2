using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._2
{
    enum Roshambo
    {
        Rock,
        Paper,
        Scissors
    }
    abstract class Player
    {
        public string Name { get; set; }
        public Roshambo Rosh { get; set; }

        public abstract Roshambo GenerateRoshambo();
       
    }
}
