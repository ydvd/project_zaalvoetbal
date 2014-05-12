using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Tamagotchi
    {
        private int health;
        private int happyness;
        private int hunger;
        private int thirst;
        private int sleep;
        public string name;
        
        public Tamagotchi()
        {
            health = 10;
            happyness = 10;
            hunger = 0;
            thirst = 0;
            sleep = 0;
        }

        public void ShowStats()
        {
            Console.Clear();
            Console.WriteLine("Health: {0}; Happyness: {0}; Hunger: {2}; Thirst: {3}; Sleep: {4}", health, happyness, hunger, thirst, sleep);
        }

        public void GiveMedicine()
        {
            health += 4;
            happyness -= 1;
            hunger += 1;
            thirst += 1;
            sleep += 1;

            if (health >= 10)
                health = 10;

            ShowStats();
            Console.WriteLine("\nYou gave {0} some medicine. His health was restored by 5.", name);

            if (health == 0 || happyness == 0 || hunger == 10 || thirst == 10 || sleep == 10)
                Die();
        }
        public void Play()
        {
            health -= 1;
            happyness += 4;
            hunger += 1;
            thirst += 1;
            sleep += 1;

            if (happyness >= 10)
                happyness = 10;

            ShowStats();
            Console.WriteLine("\nYou played a while with {0}. His happyness was restored by 5.", name);

            if (health == 0 || happyness == 0 || hunger == 10 || thirst == 10 || sleep == 10)
                Die();
        }
        public void Feed()
        {
            health -= 1;
            happyness -= 1;
            hunger -= 4;
            thirst += 1;
            sleep += 1;

            if (hunger <= 0)
                hunger = 0;

            ShowStats();
            Console.WriteLine("\nYou fed {0}. His hunger was restored by 5.", name);

            if (health == 0 || happyness == 0 || hunger == 10 || thirst == 10 || sleep == 10)
                Die();
        }
        public void Drink()
        {
            health -= 1;
            happyness -= 1;
            hunger += 1;
            thirst -= 4;
            sleep += 1;

            if (thirst <= 0)
                thirst = 0;

            ShowStats();
            Console.WriteLine("\nYou gave {0} some water. His thirst was restored by 5.", name);

            if (health == 0 || happyness == 0 || hunger == 10 || thirst == 10 || sleep == 10)
                Die();
        }
        public void Sleep()
        {
            health -= 1;
            happyness -= 1;
            hunger += 1;
            thirst += 1;
            sleep -= 4;

            if (sleep >= 10)
                sleep = 10;
            
            ShowStats();
            Console.WriteLine("\nYou let {0} rest for a while. His sleep was restored by 5.", name);

            if (health == 0 || happyness == 0 || hunger == 10 || thirst == 10 || sleep == 10)
                Die();
        }
        public void Die()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            ShowStats();
            Console.WriteLine("One of {0}'s stats has reached 0 and he has died.", name);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Do you want to play again? (y/n)");
            Console.ForegroundColor = ConsoleColor.Gray; 
            string temp = Console.ReadLine();

            if (temp == "n" || temp == "N")
                ExitGame();

        }
        public void ShowChoices()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine();
            Console.WriteLine("1. Feed {0}", name);
            Console.WriteLine("2. Give {0} something to drink", name);
            Console.WriteLine("3. Play with {0}", name);
            Console.WriteLine("4. Give {0} some rest", name);
            Console.WriteLine("5. Give {0} some medicine", name);
            Console.WriteLine("6. Exit the game");

            string strChoice = Console.ReadLine();
            int choice = Convert.ToInt32(strChoice);

            if (choice == 1)
            {
                Feed();
                ShowChoices();
            }
            else if (choice == 2)
            {
                Drink();
                ShowChoices();
            }
            else if (choice == 3)
            {
                Play();
                ShowChoices();
            }
            else if (choice == 4)
            {
                Sleep();
                ShowChoices();
            }
            else if (choice == 5)
            {
                GiveMedicine();
                ShowChoices();
            }
            else if (choice == 6)
                ExitGame();
            return;
            
        }
        public void ExitGame()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("     Thanks for playing! \n      See ya next time!");
            Console.ReadLine();
        }

    }
}
