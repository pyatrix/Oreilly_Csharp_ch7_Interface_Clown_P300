using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oreilly_Csharp_ch7_Interface_Clown_P300
{
    interface IScaryClown : IClown
    {
         string ScaryThingIHave { get; }
         void ScareLittleChildren();
    }
}
