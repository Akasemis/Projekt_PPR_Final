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
using System.Globalization;
using System.Threading;
namespace Frontendowa_aplikacja
{
    /// <summary>
    /// Interaction logic for historia.xaml
    /// </summary>
    public partial class historia : Window
    {
        public historia()
        {
            InitializeComponent();
            var serwer = new ServiceReference1.Service1Client();
            int stan = 1;
            while (stan <= serwer.ile_historii())
            {                
                historia_t.Text += serwer.zwroc_id_operacji(stan) + " " + serwer.zwroc_rase_operacji(stan) + " " + serwer.zwroc_date(stan) + "\n";
                stan++;
            }
        }
    }
}
