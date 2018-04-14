﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FactoryMF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            if(csharp.IsChecked == true)
            {
                //kill myself
            }else if(html.IsChecked == true)
            {
                //kill urself
            }
            else
            {
                //kill everyone
            } 

        }

        private void addTextBox_Click(object sender, RoutedEventArgs e)
        {
            TextBox tb = new TextBox();
            tb.Text = textBoxContent.Text;
            tb.Height = double.Parse(textBoxHeight.Text);
            tb.Width = double.Parse(textBoxWidth.Text);
            tb.Margin = new Thickness(double.Parse(textBoxLeft.Text), double.Parse(textBoxTop.Text), 0, 0);
            OurListBox.Items.Add(tb);

        }

        private void addCircle_Click(object sender, RoutedEventArgs e)
        {
            Ellipse c = new Ellipse();
            //c.text
            c.Stroke = Brushes.Red;
            c.StrokeThickness = 5;
            c.Height = double.Parse(circleHeight.Text);
            c.Width = double.Parse(circleWidth.Text);
            c.Margin = new Thickness(double.Parse(circleLeft.Text), double.Parse(circleTop.Text), 0, 0);
            OurListBox.Items.Add(c);
        }

        private void addLabel_Click(object sender, RoutedEventArgs e)
        {
            Label tb = new Label();
            tb.Content = labelContent.Text;
            tb.Height = double.Parse(labelHeight.Text);
            tb.Width = double.Parse(labelWidth.Text);
            tb.Margin = new Thickness(double.Parse(labelLeft.Text), double.Parse(labelTop.Text), 0, 0);
            OurListBox.Items.Add(tb);
        }

        private void addRectangle_Click(object sender, RoutedEventArgs e)
        {
            Rectangle tb = new Rectangle();
            //tb.Text = textBoxContent.Text;
            tb.Fill = Brushes.Black;
            tb.Height = double.Parse(rectangleHeight.Text);
            tb.Width = double.Parse(rectangleWidth.Text);
            tb.Margin = new Thickness(double.Parse(rectangleLeft.Text), double.Parse(rectangleTop.Text), 0, 0);
            OurListBox.Items.Add(tb);
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            OurListBox.Items.RemoveAt(0);
        }
    }
}
