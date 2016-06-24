using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Pet
    {
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
            }
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

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("\n=======MY=PUG=====++");
            sb.AppendLine(Name + "              ||");
            sb.AppendFormat("Hungry: {0}         ||\n", Hungry);
            sb.AppendFormat("Thirsty: {0}        ||\n", Thirsty);
            sb.AppendFormat("Bathroom: {0}   ||\n", Bathroom);
            sb.AppendFormat("Play: {0}       ||\n", Play);
            sb.AppendFormat("Doctor: {0}     ||\n", Doctor);
            sb.AppendLine("==================++");

            return sb.ToString();
        }

        public string PugName()
        {
            return Name = Console.ReadLine();
        }

        public int PugHungry()
        {

            return Hungry;
        }

        public void Tick()
        {
            //TODO
        }
    }
}
