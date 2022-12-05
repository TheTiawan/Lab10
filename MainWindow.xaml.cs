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

namespace WpfApp2
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

        List<int> array;

        private void Fill_Click(object sender, RoutedEventArgs e)
        {
            listbox.Items.Clear();
            array = null;

            Random rnd = new Random();

            array = new List<int>(rnd.Next(100));

            for (int i = 0; i < array.Capacity; i++)
            {
                array.Add(rnd.Next(-100, 100));
                listbox.Items.Add(array[i]);
            }
        }

        private void Find_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ResValueTextbox.Text = array.Where(x => x < 0).Max().ToString();
                ResIndexTextbox.Text = array.IndexOf(array.Where(x => x < 0).Max()).ToString();
            }
            catch { }
        }

        private void AboutProgram_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Составьте программу вычисления в массиве максимального среди отрицательных элементов и его номера.\nРаботу выполнил Халимов Виктор");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
