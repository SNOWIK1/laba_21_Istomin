﻿using System;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, RoutedEventArgs e)
        {
            Faculty[][] fSource = DBManager.GetFaculties();
            Group[][] gSource = DBManager.GetGroups();
            Student[][] sSource = DBManager.GetStudents();


            FacultyTable.ItemsSource = fSource[0];
            GroupTable.ItemsSource = gSource[0];
            StudentTable.ItemsSource = sSource[0];
        }

    }
}
