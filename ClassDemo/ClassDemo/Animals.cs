using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    internal class Animals
    {
        //Unlike in Java, It is not required to start with an uppercase first letter when naming classes.
        //Also, it is common that the name of the C# file and the class matches,but not required.
        //A static method can be accessed without creating an object of the class.
        //public methods can only be accessed by objects.
        //We have new access modifiers: internal, protected internal, private protected.
        //If you don't want other classes to inherit from a class, use the sealed keyword.
        private string name; // field
        private int footNum;
        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
        //Short hand property
        public int FootNum
        { get; set; }
        public virtual void animalSound()
        { Console.WriteLine("The animal makes a sound"); }
        //Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).
        //Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).
        //Interface:It's an abstract class which can only contain abstract methods and properties (with empty bodies),but not fields.

    }
}
