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
using Quiz3_NickIlkic.Services;

namespace Quiz3_NickIlkic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        StudentService ss = new StudentService();
        List<Student> ls = new List<Student>();
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool? isReg = IsRegistered.IsChecked;
            int Id = Int32.Parse(txtId.Text);
            string first = txtFirstName.Text;
            string last = txtLastName.Text;
            

            Student s = new Student(Id, first, last, isReg);

            ss.AddStudent(s);
            ls.Add(s);

            MessageBox.Show(Int32.Parse(txtId.Text) + "\n" + txtFirstName.Text + "\n" + txtLastName.Text + "\n" + isReg);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DataGrid frm2 = new DataGrid(ls);
            frm2.Show();
        }
    }
}
