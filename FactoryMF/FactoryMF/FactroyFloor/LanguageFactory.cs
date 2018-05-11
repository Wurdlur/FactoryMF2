using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FactoryMF.FactroyFloor
{
    public class LanguageFactory : Languages
    {
        internal override Languages GetLanguage(string language)
        {
            switch (language)
            {
                case "C#":
                    CSharp c = new CSharp();
                    return c;
                case "HTML":
                    HTML h = new HTML();
                    return h;
                default:
                    CSharp c2 = new CSharp();
                    return c2;
            }
        }
        internal override void GenerateCode(ListBox ourListBox)
        {
            throw new NotImplementedException();
        }
    }
}
