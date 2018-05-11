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
        internal abstract  Languages GetLanguage(string language);
        internal abstract void GenerateCode(ListBox ourListBox);
    }
}
