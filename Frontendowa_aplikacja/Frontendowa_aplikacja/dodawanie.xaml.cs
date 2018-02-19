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
    /// Interaction logic for dodawanie.xaml
    /// </summary>
    public partial class dodawanie : Window
    {
        public dodawanie()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var serwer = new ServiceReference1.Service1Client();
            int id = serwer.ile_wierszy()+1;
            string imie = imie_var.Text;
            string rasa = rasa_var.Text;
            int? wiek = Int32.Parse(wiek_var.Text);
            string kontakt = kontakt_var.Text;
            string zdj = zdj_var.Text;
            int opiekun = Int32.Parse(opiekun_var.Text);
            serwer.dodaj_zwierzaka(id, imie, rasa, wiek, kontakt, zdj, opiekun);
        }
    }
}
