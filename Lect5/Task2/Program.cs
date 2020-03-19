using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter \"yes\" if you want to move the item or \"no\" if not!");

            string choice = Console.ReadLine();

            if(choice == "yes")
            {
                char key;
                do
                {
                    Console.WriteLine("Enter where you want to move the item (W - up, S - down, A - left, D - right, X - you're at the place).");
                    
                    key = Console.ReadLine()[0];

                    switch (key)
                    {
                        case 'W':
                            Console.WriteLine("You have moved the item up");
                            break;
                        case 'S':
                            Console.WriteLine("You moved the item down");
                            break;
                        case 'A':
                            Console.WriteLine("You moved the item to the left");
                            break;
                        case 'D':
                            Console.WriteLine("You moved the item to the right");
                            break;
                        case 'X':
                            Console.WriteLine("You exit");
                            break;
                        default:
                            Console.WriteLine("Wrong key pressed");
                            break;
                    }
                } while (key != 'X');    
            }
            else if (choice == "no")
            {
                Console.WriteLine("You are exactly where you want to be!");
            }
        }
    }
}
