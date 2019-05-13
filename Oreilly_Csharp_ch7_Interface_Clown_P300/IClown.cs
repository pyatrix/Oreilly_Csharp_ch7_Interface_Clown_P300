using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oreilly_Csharp_ch7_Interface_Clown_P300
{
    interface IClown
    {
         void Honk();
         string FunnyThingIHave { get; }
    }
}
