using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Pet
    {
        Random random;
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private int _hungry;
        public int Hungry
        {
            get
            {
                return _hungry;
            }
            set
            {
                _hungry = value;
                if (_hungry < MaxHungerThirst)
                {
                    _hungry = 0;
                }
                if (_hungry > MinHungerThirst)
                {
                    _hungry = MinHungerThirst;
                }

            }
        }

        public bool IsAlive()
        {
            if (Hungry > 0)
            {
                return true;
            }

            return false;
        }

        private int _thirsty;
        public int Thirsty
        {
            get
            {
                return _thirsty;
            }
            set
            {
                _thirsty = value;
                if (_thirsty < MaxHungerThirst)
                {
                    _thirsty = 0;
                }
                if (_thirsty > MinHungerThirst)
                {
                    _thirsty = MinHungerThirst;
                }
            }
        }

        private bool _bathroom;
        public bool Bathroom
        {
            get
            {
                return _bathroom;
            }
            set
            {
                _bathroom = value;
            }
        }

        private bool _play;
        public bool Play
        {
            get
            {
                return _play;
            }
            set
            {
                _play = value;
            }
        }

        private bool _doctor;
        public bool Doctor
        {
            get
            {
                return _doctor;
            }
            set
            {
                _doctor = value;
            }
        }



        public int MaxHungerThirst { get; private set; }
        public int MinHungerThirst { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("\n=======MY=PUG=====++");
            sb.AppendLine(Name + "              ||");
            sb.AppendFormat("Hungry: {0}" + "         ||\n", Hungry);
            sb.AppendFormat("Thirsty: {0}        ||\n", Thirsty);
            sb.AppendFormat("Bathroom: {0}   ||\n", Bathroom);
            sb.AppendFormat("Play: {0}       ||\n", Play);
            sb.AppendFormat("Doctor: {0}     ||\n", Doctor);
            sb.AppendLine("==================++");

            return sb.ToString();
        }

        public Pet()
        {
            random = new Random();
            MaxHungerThirst = 1;
            MinHungerThirst = 9;
            Hungry = 1;
            Thirsty = 1;
            Bathroom = false;
            Play = false;
            Doctor = false;
        }

        public string PugName()
        {
            return Name = Console.ReadLine();
        }

        public int PugHungry()
        {
            Tick();
            if (IsAlive())
            {
                Console.WriteLine("Are you sure you want to feed {0}", Name);
                Console.WriteLine("1 for YES \t 2 for NO");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Hungry += 2;
                    if (Hungry >= MinHungerThirst)
                    {
                        Console.WriteLine("{0} is now Full!\nCarefull not too overfeed!", Name);
                    }
                    else
                    {
                        Console.WriteLine("Good job, {0} is getting fuller", Name);
                    }

                    // Method is increase thirst
                }
            }
            else if (!IsAlive() && Hungry < 1)
            {
                Console.WriteLine("{0} died of starvation!", Name);
            }
            else
            {
                Console.WriteLine("{0} ran away not feeling loved!", Name);
            }
    
            return Hungry;
        }

        public int PugThirsty()
        {
            Tick();
            if (IsAlive())
            {
                Console.WriteLine("Are you sure you want to give {0} some water", Name);
                Console.WriteLine("1 for YES \t 2 for NO");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Thirsty++;
                    //method to increase hunger
                }
            }
            else if (!IsAlive() && Thirsty < 1)
            {
                Console.WriteLine("{0} died of thirst!", Name);
            }
            else
            {
                Console.WriteLine("{0} ran away not feeling loved!", Name);
            }
            return Thirsty;
        }

        public bool PugBathroom()
        {
            Tick();
            if (IsAlive())
            {
                Console.WriteLine("Are you ready to take {0} on a bathroom trip? ", Name);
                Console.WriteLine("1 for YES \t 2 for NO");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    if(random.Next(100)+1 <= 70)
                    {
                        Console.WriteLine("{0} is atempting to pee", Name);
                        // Pee method
                    }
                    else
                    {
                        Console.WriteLine("{0} is atempting to poop", Name);
                        // Poop method
                    }
                }
            }
            else
            {
                Console.WriteLine("{0} died of starvation!", Name);
            }
            return Bathroom;
        }

        public bool PugPlay()
        {
            return Play;
        }

        public bool PugDoctor()
        {
            return Doctor;
        }

        public void Tick()
        {
            //TODO
            if (IsAlive())
            {
                if (random.Next(100)+1 <= 10)
                {
                    for (int i = Hungry; i < MinHungerThirst; i++)
                    {
                        Hungry++;
                    }
                    Console.WriteLine("{0} fed his/her self", Name);
                }

                if (random.Next(100) + 1 <= 5)
                {
                    for (int i = Thirsty; i < MinHungerThirst; i++)
                    {
                        Thirsty++;
                    }
                    Console.WriteLine("You let the toilet seat up, so {0} drank from the toilet.", Name);
                }

            }
            else
            {
                Console.WriteLine("Not feeling loved {0} ran away!", Name);
            }

        }
    }
}
