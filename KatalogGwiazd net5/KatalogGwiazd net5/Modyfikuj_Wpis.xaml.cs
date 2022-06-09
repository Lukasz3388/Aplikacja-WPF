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
using Microsoft.Win32;
using System.IO;

namespace KatalogGwiazd_net5
{
    /// <summary>
    /// Logika interakcji dla klasy Modyfikuj_Wpis.xaml
    /// </summary>
    public partial class Modyfikuj_Wpis : Window
    {
        List<SpaceModel> spaceList = new List<SpaceModel>();

        public int numberek = 0;
        public Modyfikuj_Wpis(int x)
        {
            InitializeComponent();
            numberek = x;
            SqlData();
            Wpisz_do_okna();
            
        }

        public Byte[] imageArray;

        private void btnZapisz_Click(object sender, RoutedEventArgs e)
        {
            spaceList[numberek].Title = Tytul_Modifukuj.Text;
            spaceList[numberek].Description = Content_Modyfikuj.Text;

            string base64ImageRepresentation = Convert.ToBase64String(imageArray);
            spaceList[numberek].PhotoName = base64ImageRepresentation;
            if (Tytul_Modifukuj.Text.Length > 1 && Content_Modyfikuj.Text.Length > 1)
            {
                SQLAccess.Update(spaceList[numberek], numberek);
            }
            else
            {
                MessageBox.Show("Proszę wpisać tytuł i opis");
            }
        }

        private void btnZdjecie_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                Modyfikuj_zdjecie.Source = new BitmapImage(fileUri);
                 imageArray= File.ReadAllBytes(openFileDialog.FileName);

            }
        }

        private void btnAnuluj_Click(object sender, RoutedEventArgs e)
        {
            //zamiana na usuwanie wpisów
            
            var result = MessageBox.Show("Czy napewno chcesz usunąć wpis?", "Usuwanie Wpisu", MessageBoxButton.YesNo,MessageBoxImage.Question);
            if(result == MessageBoxResult.Yes)
            {
                SQLAccess.Delete(spaceList[numberek]);
                this.Close();
            }
            
        }
        private void SqlData()
        {
            SQLAccess.CreateTableSpaces();
            spaceList = SQLAccess.Read();
        }
        private void Wpisz_do_okna()
        {
            
            Tytul_Modifukuj.Text = spaceList[numberek].Title;
            Content_Modyfikuj.Text = spaceList[numberek].Description;
            wyswietlzdj(spaceList[numberek].PhotoName);
        }
        private void wyswietlzdj(string x)
        {
            imageArray = Convert.FromBase64String(x);
            byte[] zdjwbajtach = Convert.FromBase64String(x);
            BitmapImage bitmapimg = new BitmapImage();
            bitmapimg.BeginInit();
            bitmapimg.StreamSource = new MemoryStream(zdjwbajtach);
            bitmapimg.EndInit();
            Modyfikuj_zdjecie.Source = bitmapimg;
        }


    }
}
