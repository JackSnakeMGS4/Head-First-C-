using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Little_s_Interface_Practice
{
    interface IClown
    {
        //private isn't valid for interfaces since evertyhing is automatically public
        //private void Honk();

        //Remember that to any class that implements an interfaces properties look just like a field
        //So interfaces are sort of like a promise that you will add all methods and properties to any class implementing it
        void Honk();
        string FunnyThingIHave { get; }
    }
}
