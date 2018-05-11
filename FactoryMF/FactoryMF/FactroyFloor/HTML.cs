using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FactoryMF.FactroyFloor
{
    public class HTML : Languages
    {
        internal override Languages GetLanguage(string language)
        {
            throw new NotImplementedException();
        }
        internal override void GenerateCode(ListBox ourListBox)
        {
            string s = @"<!DOCTYPE html> /r/n
                        <html> /r/n
                        <head></head> /r/n
                        <body> /r/n";
            File.WriteAllText(@"C:\Users\John\Documents\GitHub\FactoryMF2\FactoryMF\FactoryMF\TextFiles", s);
            for (int i = 0; i < ourListBox.Items.Count; i++)
            {
                using (StreamWriter file = new StreamWriter(@"C: \Users\John\Documents\GitHub\FactoryMF2\FactoryMF\FactoryMF\TextFiles\CSharp/txt", true))
                {
                    Type aType = ourListBox.Items[i].GetType();
                    if (aType == typeof(TextBox))
                    {
                        string t = ((TextBox)ourListBox.Items[i]).Text;
                        double w = ((TextBox)ourListBox.Items[i]).Width;
                        double h = ((TextBox)ourListBox.Items[i]).Height;
                        double d = ((TextBox)ourListBox.Items[i]).Margin.Top;
                        double l = ((TextBox)ourListBox.Items[i]).Margin.Left;
                        file.WriteLine($"<TextBox Width=\"{w}\" Height =\"{h}\" Margin=\"{d}, {l}, 0, 0\">{t}</TextBox>");
                    }
                    else if (aType == typeof(Label))
                    {
                        string t = ((Label)ourListBox.Items[i]).Content.ToString();
                        double w = ((Label)ourListBox.Items[i]).Width;
                        double h = ((Label)ourListBox.Items[i]).Height;
                        double d = ((Label)ourListBox.Items[i]).Margin.Top;
                        double l = ((Label)ourListBox.Items[i]).Margin.Left;
                        file.WriteLine($"<Label Width=\"{w}\" Height =\"{h}\" Margin=\"{d}, {l}, 0, 0\">{t}</Label>");
                    }
                }
            }
            using (StreamWriter file = new StreamWriter(@"C: \Users\John\Documents\GitHub\FactoryMF2\FactoryMF\FactoryMF\TextFiles\CSharp.txt", true))
            {
                file.WriteLine(@"</body> /r/n
                                </html> ");
            }
        }
    }
}
