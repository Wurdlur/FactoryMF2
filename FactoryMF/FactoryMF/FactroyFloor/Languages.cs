using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMF.FactroyFloor
{
    abstract public class Languages
    {
        public Languages Language(string s)
        {
            Languages l = GetLanguage(s);
            return l;
        }
        abstract protected Languages GetLanguage(string language);
    }
}
