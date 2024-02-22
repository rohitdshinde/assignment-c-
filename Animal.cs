using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animal
    {
        public virtual void sound()
        {
            Console.WriteLine("I am Animal");
        }
    }
    class cat : Animal
    {
        public override void sound()
        {
            Console.WriteLine("I am not Animal");
        }      
         public static void Main(string[] args)
        {
            cat c = new cat();
            c.sound();
        }
    }
}
