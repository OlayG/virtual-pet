using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to Virtual Pug\nEnjoy your jorney as a Virtual Pug Owner\n");
            Menu();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nSeems your Virtual Pug has gotten really sick.\nMaybe you're not cut out for this.\nPress any key to exit");
            Console.ResetColor();
            Console.ReadKey();
        }

        private static void Menu()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Thank you for adopting!");
            Pet newPug = new Pet();
            Console.WriteLine("Enter a name for your new pug");
            newPug.Name = newPug.PugName();
            Console.ResetColor();

            int selection;

            do
            {
                newPug.PlayWithPug();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                //Console.WriteLine("\n" + newPug.ToString());
                Console.WriteLine(newPug.ToString());
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------+");
                Console.WriteLine("1. Give {0} some food.                         |", newPug.Name);
                Console.WriteLine("2. Give {0} some water.                        |", newPug.Name);
                Console.WriteLine("3. Take {0} out to the bathroom                |", newPug.Name);
                Console.WriteLine("4. Play with {0}                               |", newPug.Name);
                Console.WriteLine("5. Take {0} to the doctor                      |", newPug.Name);
                Console.WriteLine("6. Kill {0}                                    |", newPug.Name);
                Console.WriteLine("------------------------------------------------+");
                Console.WriteLine();
                Console.ResetColor();

                

                selection = Convert.ToInt32(Console.ReadLine());

                if (selection == 1)
                {                    
                    newPug.PugHungry();
                }
                else if (selection == 2)
                {
                    newPug.PugThirsty();
                }
                else if (selection == 3)
                {
                    //PrintStudentList();
                }
                else if (selection == 4)
                {
                    newPug.PugPlay();
                }
                else if (selection == 5)
                {
                    //PrintStudentList();
                }
                else
                {
                    continue;
                }



            } while (selection != 6 && newPug.IsAlive());
        }
    }
}
