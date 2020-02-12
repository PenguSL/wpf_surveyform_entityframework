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

namespace Register
{
    /// <summary>
    /// Interaction logic for Form8.xaml
    /// </summary>
    public partial class Form8 : Window
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Close();
        }
    }
}
