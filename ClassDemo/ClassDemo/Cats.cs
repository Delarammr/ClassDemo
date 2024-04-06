using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    internal class Cats : Animals
    {
        public override void animalSound()
        { Console.WriteLine("The cat says: mio mio"); }
    }
}
