using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi tama = new Tamagotchi();
            Console.WriteLine("Welcome to the Tamagotchi simulator.");

            Console.Write("First, please enter a name for your new pet. ");
            tama.name = Console.ReadLine();

            tama.ShowChoices();

            //Console.WriteLine("Press a key to continue...");
            //Console.ReadKey();
        }
    }
}
