using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

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
        internal abstract void GenerateCode(ListBox ourListBox);
    }
}
