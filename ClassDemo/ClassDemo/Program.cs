using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals myAnimal = new Animals();
            Animals myCat = new Cats();
            Animals myDog = new Dogs();  

            myAnimal.animalSound();
            myCat.animalSound();
            myDog.animalSound();
        }
    }
}
