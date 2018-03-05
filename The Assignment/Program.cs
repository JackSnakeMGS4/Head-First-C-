using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Little_s_Interface_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            TallGuy guy = new TallGuy("This is it! The Day of Lavos[]@#%!", 999);
            guy.TalkAboutYourself();
            guy.Honk();
            Console.WriteLine(guy.FunnyThingIHave);
        }
    }
}
