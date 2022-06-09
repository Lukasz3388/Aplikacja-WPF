using System;
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
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

namespace KatalogGwiazd_net5
{
    /// <summary>
    /// Logika interakcji dla klasy Nowy_Wpis.xaml
    /// </summary>
    public partial class Nowy_Wpis : Window
    {
        List<SpaceModel> spaceList = new List<SpaceModel>();

        public Nowy_Wpis()
            {
            InitializeComponent();
            }
        public Byte[] imageArray;
        private void btnZapisz_Click(object sender, RoutedEventArgs e)
            {

            
            if (Tytul_Nowy_wpis.Text.Length > 1 && imageArray.Length>30 && Content_Nowy_wpis.Text.Length>1)
            {
                string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                SQLAccess.Create(Tytul_Nowy_wpis.Text, Content_Nowy_wpis.Text, base64ImageRepresentation);
            }
            else
            {
                MessageBox.Show("Proszę uzupełnić wszystko wraz ze wstawieniem zdjęcia");
            }
        }

            private void btnZdjecie_Click(object sender, RoutedEventArgs e)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                    Uri fileUri = new Uri(openFileDialog.FileName);
                    Nowy_zdjecie.Source = new BitmapImage(fileUri);
                imageArray = File.ReadAllBytes(openFileDialog.FileName);
            }
            }

            private void btnAnuluj_Click(object sender, RoutedEventArgs e)
            {
                this.Close();
            }
        
    }
    }
