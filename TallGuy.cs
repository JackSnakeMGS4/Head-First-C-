using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Little_s_Interface_Practice
{
    class TallGuy: IClown
    {
        //without encapsulation as per the assignment
        /*public string Name;
        public int Height;

        public void TalkAboutYourself()
        {
            Console.WriteLine("My name is " + Name + " and I'm " + Height + " inches tall.");
        }

        public string FunnyThingIHave { get { return "Whoa! Biiig."; } }
        public void Honk()
        {
            Console.WriteLine("Honk! Honk!");
        }*/

        //with my little black box of dooooooom (encapsulation... oh by the by, this portion was just my version of a simpler assignment)
        private string name;
        private int height;

        public TallGuy(string Name, int Height)
        {
            name = Name;
            height = Height;
        }

        public void TalkAboutYourself()
        {
            Console.WriteLine("Here's my name (note not really a name): " + name + " and here's my damage #getRekted: " + height);
        }

        public void Honk()
        {
            Console.WriteLine("Honk! Honk!");
        }

        public string FunnyThingIHave { get { return "Pow! Pew! Booooooom!"; } }
    }
}
