using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

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
            string s = @"<Window x:Class=""FactoryMF.MainWindow2"" \r\n
                       xmlns = ""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" \r\n
                       xmlns: x = ""http://schemas.microsoft.com/winfx/2006/xaml"" \r\n
                       xmlns: d = ""http://schemas.microsoft.com/expression/blend/2008"" \r\n
                       xmlns: mc = ""http://schemas.openxmlformats.org/markup-compatibility/2006"" \r\n
                       xmlns: local = ""clr-namespace:FactoryMF"" \r\n
                       mc: Ignorable = ""d"" \r\n
                       Title = ""DemoFactory"" Height = ""360"" Width = ""525"" > \r\n
                       < Grid > ";
            File.WriteAllText(@"C:\Users\John\Documents\GitHub\FactoryMF2\FactoryMF\FactoryMF\TextFiles", s);
            for(int i = 0; i < ourListBox.Items.Count; i++)
            {
                using(StreamWriter file = new StreamWriter(@"C: \Users\John\Documents\GitHub\FactoryMF2\FactoryMF\FactoryMF\TextFiles\CSharp/txt", true))
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
                    } else if(aType == typeof(Ellipse))
                    {
                        double w = ((Ellipse)ourListBox.Items[i]).Width;
                        double h = ((Ellipse)ourListBox.Items[i]).Height;
                        double d = ((Ellipse)ourListBox.Items[i]).Margin.Top;
                        double l = ((Ellipse)ourListBox.Items[i]).Margin.Left;
                        file.WriteLine($"<Ellipse Width=\"{w}\" Height=\"{h}\" Margin=\"{d}, {l}, 0, 0\" Stroke=\"Red\" StrokeThickness=\"5\"><Ellipse>");
                    } else if(aType == typeof(Label))
                    {
                        string t = ((Label)ourListBox.Items[i]).Content.ToString();
                        double w = ((Label)ourListBox.Items[i]).Width;
                        double h = ((Label)ourListBox.Items[i]).Height;
                        double d = ((Label)ourListBox.Items[i]).Margin.Top;
                        double l = ((Label)ourListBox.Items[i]).Margin.Left;
                        file.WriteLine($"<Label Width=\"{w}\" Height =\"{h}\" Margin=\"{d}, {l}, 0, 0\">{t}</Label>");
                    } else if(aType == typeof(Rectangle))
                    {
                        double w = ((Rectangle)ourListBox.Items[i]).Width;
                        double h = ((Rectangle)ourListBox.Items[i]).Height;
                        double d = ((Rectangle)ourListBox.Items[i]).Margin.Top;
                        double l = ((Rectangle)ourListBox.Items[i]).Margin.Left;
                        file.WriteLine($"<Rectangle Width=\"{w}\" Height=\"{h}\" Margin=\"{d}, {l}, 0, 0\" Stroke=\"Red\" StrokeThickness=\"5\"><Rectangle>");
                    }
                }
            }
            using (StreamWriter file = new StreamWriter(@"C: \Users\John\Documents\GitHub\FactoryMF2\FactoryMF\FactoryMF\TextFiles\CSharp.txt", true))
            {
                file.WriteLine(@"</Grid> /r/n
                                </Window> ");
            }
        }
    }
}
