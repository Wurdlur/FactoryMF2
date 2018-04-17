using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FactoryMF.FactroyFloor
{
    public class CSharp : Languages
    {
        protected override Languages GetLanguage(string language)
        {
            CSharp s = new CSharp();
            return s;
        }
        internal override void GenerateCode(ListBox ourListBox)
        {
            throw new NotImplementedException();
        }
    }
}
