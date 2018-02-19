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
using System.Windows.Shapes;

namespace Frontendowa_aplikacja
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int stan = 1;
        public MainWindow()
        {
            InitializeComponent();
            var serwer = new ServiceReference1.Service1Client();
            imie_t.Content = serwer.zwroc_imie(1);
            rasa_t.Content = serwer.zwroc_rase(1);
            wiek_t.Content = Convert.ToString(serwer.zwroc_wiek(1));
            kontakt_t.Content = serwer.zwroc_kontakt(1);
            var uriSource = new Uri("zdj/1.jpg", UriKind.Relative);
            img.Source = new BitmapImage(uriSource);
            opiekun_t.Content = serwer.zwroc_opiekuna(1);
        }

        private void zwierzak_next(object sender, RoutedEventArgs e)
        {
            var serwer = new ServiceReference1.Service1Client();
            int ile = serwer.ile_wierszy();
            if (stan < ile)
            {
                stan++;
                while (serwer.zwroc_opiekuna(stan) == 0)
                    stan++;
                imie_t.Content = serwer.zwroc_imie(stan);
                rasa_t.Content = serwer.zwroc_rase(stan);
                wiek_t.Content = Convert.ToString(serwer.zwroc_wiek(stan));
                kontakt_t.Content = serwer.zwroc_kontakt(stan);
                var uriSource = new Uri("zdj/" + serwer.zwroc_zdj(stan), UriKind.Relative);
                img.Source = new BitmapImage(uriSource);
                opiekun_t.Content = serwer.zwroc_opiekuna(stan);
            }
            else
            {
                stan = 1;
                while (serwer.zwroc_opiekuna(stan) == 0)
                    stan++;
                imie_t.Content = serwer.zwroc_imie(stan);
                rasa_t.Content = serwer.zwroc_rase(stan);
                wiek_t.Content = Convert.ToString(serwer.zwroc_wiek(stan));
                kontakt_t.Content = serwer.zwroc_kontakt(stan);
                var uriSource = new Uri("zdj/" + serwer.zwroc_zdj(stan), UriKind.Relative);
                img.Source = new BitmapImage(uriSource);
                opiekun_t.Content = serwer.zwroc_opiekuna(stan);
            }
        }

        private void zwierzak_prev(object sender, RoutedEventArgs e)
        {
            var serwer = new ServiceReference1.Service1Client();
            int ile = serwer.ile_wierszy();
            if (stan > 1)
            {
                stan--;
                while (serwer.zwroc_opiekuna(stan) == 0)
                {
                    if (stan <= 1)
                        stan = ile;
                    else
                        stan--;
                }
                imie_t.Content = serwer.zwroc_imie(stan);
                rasa_t.Content = serwer.zwroc_rase(stan);
                wiek_t.Content = Convert.ToString(serwer.zwroc_wiek(stan));
                kontakt_t.Content = serwer.zwroc_kontakt(stan);
                var uriSource = new Uri("zdj/" + serwer.zwroc_zdj(stan), UriKind.Relative);
                img.Source = new BitmapImage(uriSource);
                opiekun_t.Content = serwer.zwroc_opiekuna(stan);

            }
            else
            {
                while (serwer.zwroc_opiekuna(stan) == 0)
                {
                    if (stan <= 1)
                        stan = ile;
                    else
                        stan++;
                }
                stan = serwer.ile_wierszy();
                imie_t.Content = serwer.zwroc_imie(stan);
                rasa_t.Content = serwer.zwroc_rase(stan);
                wiek_t.Content = Convert.ToString(serwer.zwroc_wiek(stan));
                kontakt_t.Content = serwer.zwroc_kontakt(stan);
                var uriSource = new Uri("zdj/" + serwer.zwroc_zdj(stan), UriKind.Relative);
                img.Source = new BitmapImage(uriSource);
                opiekun_t.Content = serwer.zwroc_opiekuna(stan);
            }
        }

        private void dodawanie_Click(object sender, RoutedEventArgs e)
        {
            dodawanie dodawanie = new dodawanie();
            dodawanie.Show();
            opiekun_t.Content = "Zwierzak adoptowany!";
        }

        private void adoptuj_Click(object sender, RoutedEventArgs e)
        {
            var serwer = new ServiceReference1.Service1Client();
            serwer.modyfikuj_zwierzaka(stan);
            int id = serwer.ile_historii()+1;
            serwer.dodaj_historie(id, serwer.zwroc_rase(stan), DateTime.Now);
            MessageBox.Show("Adoptowano zwierzaka!");
            zwierzak_next(sender, e);
        }

        private void Historia_Click(object sender, RoutedEventArgs e)
        {
            historia historia = new historia();
            historia.Show();
        }
    }
}
