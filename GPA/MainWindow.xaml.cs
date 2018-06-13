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

namespace GPA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            int c1, c2, c3, c4, c5;
            int g1, g2, g3, g4, g5;
            int sumofcredits = 0;
            c1 = int.Parse(t1.Text);
            c2 = int.Parse(t2.Text);
            c3 = int.Parse(t3.Text);
            c4 = int.Parse(t4.Text);
            c5 = int.Parse(t5.Text);
            g1 = int.Parse(tt1.Text);
            g2 = int.Parse(tt2.Text);
            g3 = int.Parse(tt3.Text);
            g4 = int.Parse(tt4.Text);
            g5 = int.Parse(tt5.Text);
            sumofcredits = c1 + c2 + c3 + c4 + c5;
            double result = (double)(c1 * g1 + c2 * g2 + c3 * g3 + c4 * g4 + c5 * g5) / (double)sumofcredits;
            res.Text = result.ToString();

        }
    }
}
