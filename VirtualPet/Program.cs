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
            Console.Write("Welcome to Virtual Pug\nWould you like to adopt a Virtual baby Pug\nPress \"1\" for YES and \"2\" for NO\n");
            int response = Convert.ToInt32(Console.ReadLine());

            if (response == 1)
            {
                Menu();
            }

            Console.WriteLine("We understand, maybe on your next vist\n Press any key to exit");
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



            int selection; // Initiated outside of the loop

            do
            {

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\n" + newPug.ToString());
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------+");
                Console.WriteLine("1. Feed {0}                                    |", newPug.Name);
                Console.WriteLine("2. Quench {0}                                  |", newPug.Name);
                Console.WriteLine("3. Take {0} out for bathroom                   |", newPug.Name);
                Console.WriteLine("4. Play with {0}                               |", newPug.Name);
                Console.WriteLine("5. Take {0} to the doctor                      |", newPug.Name);
                Console.WriteLine("6. Kill {0}                                    |", newPug.Name);
                Console.WriteLine("------------------------------------------------+");
                Console.WriteLine();
                Console.ResetColor();



                selection = Convert.ToInt32(Console.ReadLine());

                if (selection == 1)
                {
                    //EnrollStudent();
                }
                else if (selection == 2)
                {
                    //UnEnrollStudent();
                }
                else if (selection == 3)
                {
                    //PrintStudentList();
                }
                else if (selection == 4)
                {
                    //PrintStudentList();
                }
                else if (selection == 5)
                {
                    //PrintStudentList();
                }
                else
                {
                    continue;
                }



            } while (selection != 6);
        }
    }
}
