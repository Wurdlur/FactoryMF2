using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMF.FactroyFloor
{
    abstract public class Languages
    {
        abstract protected Languages GetLanguage(string language);
    }
}
