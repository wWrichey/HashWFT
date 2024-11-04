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

namespace HashWFT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList;
        public MainWindow()
        {
            InitializeComponent();
            sortedList = new SortedList();
        }

        

        private void ke_Click(object sender, RoutedEventArgs e)
        {
            string showAll = string.Empty;

            sortedList.Add(int.Parse(keyTxt.Text), valueTxt.Text);

            //key value จะเป็นอะไรก็ได้
            ICollection collection = sortedList.Keys;
            foreach (int key in collection)
            {
                showAll += (sortedList[key].ToString() + "\n");
                //MessageBox.Show(sortedList[key].ToString());
            }
            MessageBox.Show(showAll);
        }
    }
}
