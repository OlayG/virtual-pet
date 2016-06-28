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
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n");
            Console.Write("\t\t\t  Welcome to Virtual Pug\n\t\t Enjoy your jorney as a Virtual Pug Owner\n");
            Console.WriteLine("\n\t\t\t      Tap to continue");
            Console.ReadKey();
            Console.Clear();
            Menu();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            //Seems your Virtual Pug has gotten really sick.\n
            Console.WriteLine("\nMaybe you're not cut out for this.\nPress any key to exit");
            Console.ResetColor();
            Console.ReadKey();
        }

        private static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("-------------------------------------------------------------------------");
            //Console.WriteLine("Thank you for adopting!\n");
            Pet newPug = new Pet();
            Console.WriteLine("What would you like to name your pug?");
            newPug.Name = newPug.PugName();
            Console.ResetColor();

            int selection;

            do
            {
                if (newPug.Play)
                {
                    newPug.PlayWithPug();
                }
                else if (newPug.Doctor)
                {
                    newPug.DoctorVisit();
                }
                else
                {
                    
                }

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                //Console.WriteLine("\n" + newPug.ToString());
                Console.WriteLine(newPug.ToString());
                Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine();
                Console.WriteLine("------------------------------------------------+");
                Console.WriteLine("1. Give {0} some food.", newPug.Name);
                Console.WriteLine("------------------------------------------------+");
                Console.WriteLine("2. Give {0} some water.", newPug.Name);
                Console.WriteLine("------------------------------------------------+");
                Console.WriteLine("3. Take {0} out to the bathroom.", newPug.Name);
                Console.WriteLine("------------------------------------------------+");
                Console.WriteLine("4. Play with {0}.", newPug.Name);
                Console.WriteLine("------------------------------------------------+");
                Console.WriteLine("5. Take {0} to the vet.", newPug.Name);
                Console.WriteLine("------------------------------------------------+");
                Console.WriteLine("6. Release {0}.", newPug.Name);
                Console.WriteLine("------------------------------------------------+");
                Console.WriteLine();
                Console.ResetColor();

                Temperment feelings = new Temperment();
                if (newPug.Hungry < 4)
                {
                    feelings.CharmingPug();
                }
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
                    newPug.PugDoctor();
                }
                else
                {
                    continue;
                }



            } while (selection != 6 && newPug.IsAlive());
        }
    }
}
