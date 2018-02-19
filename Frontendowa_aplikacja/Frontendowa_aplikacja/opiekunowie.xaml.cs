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

namespace Frontendowa_aplikacja
{
    /// <summary>
    /// Interaction logic for opiekunowie.xaml
    /// </summary>
    public partial class opiekunowie : Window
    {
        public opiekunowie()
        {
            InitializeComponent();
            var serwer = new ServiceReference1.Service1Client();
            int stan = 1;
            while (stan <= serwer.ile_opieuknow())
            {
                opiekunowie_t.Text += serwer.zwroc_id_opiekuna(stan) + " " + serwer.zwroc_imie_opiekuna(stan) + " " + serwer.zwroc_nazwisko_opiekuna(stan) + " " + serwer.zwroc_pensje_opiekuna(stan) + "zł \n";
                stan++;
            }
        }

        private void mod_Click(object sender, RoutedEventArgs e)
        {
            var serwer = new ServiceReference1.Service1Client();
            int id = Int32.Parse(id_var.Text);
            int dodatek = Int32.Parse(dodatek_var.Text);
            serwer.modyfikuj_pensje(id, dodatek);
            MessageBox.Show("Zmodyfikowano pensje pracownika!");
            opiekunowie_t.Text = "";
            int stan = 1;
            while (stan <= serwer.ile_opieuknow())
            {
                opiekunowie_t.Text += serwer.zwroc_id_opiekuna(stan) + " " + serwer.zwroc_imie_opiekuna(stan) + " " + serwer.zwroc_nazwisko_opiekuna(stan) + " " + serwer.zwroc_pensje_opiekuna(stan) + "zł \n";
                stan++;
            }
        }
    }
}
