using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace Projekt1
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Random rand = new Random();
        int val = 0;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Przycisk_Click(object sender, RoutedEventArgs e)
        {
            GenerujLiczby();
        }

        private void GenerujLiczby()
        {
            val = rand.Next(1, 49);
            Wyg1.Text = val.ToString();

            val = rand.Next(1, 49);
            while(val.ToString().Equals(Wyg1.Text))
                val = rand.Next(1, 49);
            Wyg2.Text = val.ToString();

            val = rand.Next(1, 49);
            while (val.ToString().Equals(Wyg1.Text) || val.ToString().Equals(Wyg2.Text))
                val = rand.Next(1, 49);
            Wyg3.Text = val.ToString();

            val = rand.Next(1, 49);
            while (val.ToString().Equals(Wyg1.Text) || val.ToString().Equals(Wyg2.Text) || val.ToString().Equals(Wyg3.Text))
                val = rand.Next(1, 49);
            Wyg4.Text = val.ToString();

            val = rand.Next(1, 49);
            while (val.ToString().Equals(Wyg1.Text) || val.ToString().Equals(Wyg2.Text) || val.ToString().Equals(Wyg3.Text) || val.ToString().Equals(Wyg4.Text))
                val = rand.Next(1, 49);
            Wyg5.Text = val.ToString();

            val = rand.Next(1, 49);
            while (val.ToString().Equals(Wyg1.Text) || val.ToString().Equals(Wyg2.Text) || val.ToString().Equals(Wyg3.Text) || val.ToString().Equals(Wyg4.Text) || val.ToString().Equals(Wyg5.Text))
                val = rand.Next(1, 49);
            Wyg6.Text = val.ToString();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Money_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged_1(object sender, RoutedEventArgs e)
        {

        }

        private void Num1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Num2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Num3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Num4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Num5_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Num6_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged_2(object sender, RoutedEventArgs e)
        {

        }

        private void Przycisk2_Click_1(object sender, RoutedEventArgs e)
        {
            Wyg1.Text = String.Empty;
            Wyg2.Text = String.Empty;
            Wyg3.Text = String.Empty;
            Wyg4.Text = String.Empty;
            Wyg5.Text = String.Empty;
            Wyg6.Text = String.Empty;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
