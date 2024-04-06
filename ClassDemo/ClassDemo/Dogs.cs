using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    internal class Dogs : Animals
    {
        public override void animalSound()
        { Console.WriteLine("The dog says: wof wof"); }
    }
}
