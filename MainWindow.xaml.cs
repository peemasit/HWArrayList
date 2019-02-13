using System;
using System.Collections;
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

namespace ArrayListHW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Add(txtData.Text);
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Remove(txtData.Text);
        }

        private void Show_Click(object sender, RoutedEventArgs e)
        {
            foreach (object data in arrayList)
            {
                MessageBox.Show(data.ToString());
            }
            
        }

        private void TxtData_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
