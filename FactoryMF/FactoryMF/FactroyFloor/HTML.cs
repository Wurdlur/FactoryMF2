﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FactoryMF.FactroyFloor
{
    public class HTML : Languages
    {
        protected override Languages GetLanguage(string language)
        {
            HTML h = new HTML();
            return h;
        }
        internal override void GenerateCode(ListBox ourListBox)
        {
            throw new NotImplementedException();
        }
    }
}
