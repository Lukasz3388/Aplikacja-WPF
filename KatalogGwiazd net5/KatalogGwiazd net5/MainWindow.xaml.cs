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
using System.Windows.Navigation;
using System.IO;
using System.Windows.Shapes;

namespace KatalogGwiazd_net5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<SpaceModel> spaceList = new List<SpaceModel>();
        public MainWindow()
        {
            InitializeComponent();
            
            SqlData();
            lista.SelectedIndex = 0;
        }
        public int przeslij;

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnModify_Click(object sender, RoutedEventArgs e)
        {
            Modyfikuj_Wpis ModyfikujWindow = new Modyfikuj_Wpis(przeslij);
            ModyfikujWindow.ShowDialog();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            Nowy_Wpis newWindow = new Nowy_Wpis();
            newWindow.ShowDialog();
        }

        private void SqlData()
        {
            SQLAccess.CreateTableSpaces();
            spaceList = SQLAccess.Read();
            Nazwa_Gwiazdy.Content = spaceList[0].Title;
            lista.ItemsSource = spaceList.Select(n => n.Title);
        }
       private void ListaWpisow(object sender, RoutedEventArgs e)
        {
            SqlData();
            if (lista.SelectedItem != null)
            {
                
                int selectedIndex = lista.SelectedIndex;
                przeslij = selectedIndex;
                Nazwa_Gwiazdy.Content = spaceList[selectedIndex].Title;
                Textspace.Text = spaceList[selectedIndex].Description;
                wyswietlzdj(spaceList[selectedIndex].PhotoName);
                
            }
        }
        private void wyswietlzdj(string x)
        {
            byte[] zdjwbajtach = Convert.FromBase64String(x);
            BitmapImage bitmapimg = new BitmapImage();
            bitmapimg.BeginInit();
            bitmapimg.StreamSource = new MemoryStream(zdjwbajtach);
            bitmapimg.EndInit();
            zdjecie.Source = bitmapimg;
        }
    }
}
