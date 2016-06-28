using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Temperment
    {
        Pet Pug = new Pet();
        public void CharmingPug()
        {
            //Pugs are naturally beautiful dogs. They are small with an adorable face that will make anyone want to hold and cuddle them. 
            //Of course they know this and will use every opportunity they have to charm you.
            
            Console.WriteLine("{0} says gimmi food you fool!\nbut you see it as a cute jesture for food");
        }

        public void DocilePug()
        {
            //He will become more docile, meaning that he will be more willing to be controlled and will be willing to do what you tell him. 
            //This is a wonderful quality as it is easier to train your pug to listen to you and make yourself the household leader in his life.
            Console.WriteLine("Pug is sad");
        }

        public void CleverPug()
        {
            //By being fairly smart dogs, you can expect your pug to be pretty clever.
            Console.WriteLine("Something");
        }

        public void StubbornPug()
        {
            //Having a natural stubborn personality, most pugs will do what they want to do and 
            //if they do not receive the proper training it can be hard to change their mind.
            Console.WriteLine("{0} is getting tired of these snacks wants the ones scooby has");
        }

        public void SociablePug()
        {
            //You never want your Pug to be in complete isolation. 
            //Leaving for work and such is ok, but to leave him unattended for long periods of time will put a lot of stress on him. 
            //He is a social creature that will always seek to be with someone.
            Console.WriteLine("{0} is feeling extra good today showing you more affection than usual");
        }
    }
}
