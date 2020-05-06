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
using Quiz3_NickIlkic.Services;


namespace Quiz3_NickIlkic
{
    /// <summary>
    /// Interaction logic for NumberChecker.xaml
    /// </summary>
    public partial class NumberChecker : Window
    {
        public NumberChecker()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            List<int> list = new List<int>() { 55, 200, 740, 76, 230, 482, 95 };
            NumbersChecker nc = new NumbersChecker();
            List<int> returnList = nc.CheckList(list);
            string nums = "";
            foreach (int i in returnList)
            {
                nums = nums + i.ToString() + " ";
            }

            MessageBox.Show("Numbers greater than 80: " + nums);
            
        }
    }
}
