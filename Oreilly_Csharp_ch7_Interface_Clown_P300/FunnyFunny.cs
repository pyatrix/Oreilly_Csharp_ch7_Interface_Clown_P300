using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oreilly_Csharp_ch7_Interface_Clown_P300
{
    class FunnyFunny : IClown
    {
        private string funnyThingIHave;

        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }

        public string FunnyThingIHave { get { return " Hi kid! I have " + funnyThingIHave; }  }

        public void Honk()
        {
            Console.WriteLine(this.FunnyThingIHave);
        }
    }
}
