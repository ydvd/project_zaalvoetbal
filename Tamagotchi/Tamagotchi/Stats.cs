using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Stats
    {
        int health;
        int happyness;
        int hunger;
        int thirst;
        int sleep;

        public Stats()
        {
            health = 10;
            happyness = 10;
            hunger = 10;
            thirst = 10;
            sleep = 10;
        }

        public void ShowStats()
        {
            //boven aan het scherm de stats weergeven
            Console.Clear();
            Console.WriteLine("Health: {0}; Happyness: {0}; Hunger: {2}; Thirst: {3}; Sleep: {4}", health, happyness, hunger, thirst, sleep);
        }
    }
}
