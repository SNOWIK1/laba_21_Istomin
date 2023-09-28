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

namespace Laba_21
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        Faculty[][] fSource = DBManager.GetFaculties();
        Group[][] gSource = DBManager.GetGroups();
        Student[][] sSource = DBManager.GetStudents();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, RoutedEventArgs e)
        {
            FacultyTable.ItemsSource = fSource[FacultyTable.Page];
            GroupTable.ItemsSource = gSource[GroupTable.Page];
            StudentTable.ItemsSource = sSource[StudentTable.Page];
        }

        private void NextPage(object sender, RoutedEventArgs e)
        {
            StudentTable.Page = StudentTable.Page + 1;

            StudentTable.ItemsSource = sSource[StudentTable.Page];
        }
    }
}
