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
using System.Collections.ObjectModel;

namespace StudentRegister
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Student> students;

        public MainWindow()
        {
            InitializeComponent();
            students = new ObservableCollection<Student>();
            students.Add(new Student("Jack", "Nimble"));
            students.Add(new Student("Mary", "Contrary"));
            StudentList.ItemsSource = students;
            SelectedStudent.Content = students;
        }


        public void AddStudent(object sender, EventArgs args)
        {
            students.Add(new Student("J", "Doe"));
        }
    }
}
