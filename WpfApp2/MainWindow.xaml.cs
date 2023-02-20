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
using Microsoft.Win32;
using System.IO;

namespace WpfApp2   
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //vygeneruje random
            Random rnd = new Random();
            string[] jmena = { "Jacob", "Jonathan", "Markounek", "Fiji", "Karl" };
            string[] prijmeni = { "Evergreen", "Miles", "Sussy", "Black", "Claun", "Niga" };
            string name = "";
            //opakování
            int cislo = Convert.ToInt32(select.Text); 
            for(int i = 0; i < cislo; i++)
            { 

                string jmeno = jmena[rnd.Next(0, 5)];
                string prijmeno = prijmeni[rnd.Next(0, 6)];

                name += ($"{jmeno} {prijmeno}\n");
            }
            SaveFileDialog ukladacDialog = new SaveFileDialog();
            ukladacDialog.DefaultExt = ".txt";
            ukladacDialog.Filter = "Textove dokumenty (.txt)|*txt";
            if (ukladacDialog.ShowDialog() == true)
            {
                string nazevSouboru = ukladacDialog.FileName;
                MessageBox.Show("Zjištěn název složky");
                string textKZapsani = name;
                File.AppendAllText(nazevSouboru, textKZapsani);

            }
            else
            {
                MessageBox.Show("Něco se nepovedlo");
            }    
        }
    }
}
