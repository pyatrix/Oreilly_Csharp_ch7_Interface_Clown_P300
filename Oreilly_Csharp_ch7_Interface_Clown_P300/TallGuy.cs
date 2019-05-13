using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oreilly_Csharp_ch7_Interface_Clown_P300
{
    class TallGuy
    {
        public string Name;
        public int Height;
        public void TalkAboutYourself()
        {
            Console.WriteLine("My Name is " + Name + " and I 'm " + Height + " inches tall.");
        }
    }
}
