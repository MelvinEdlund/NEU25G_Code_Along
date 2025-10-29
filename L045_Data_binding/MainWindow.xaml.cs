﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace L045_Data_binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Person PersonA { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            PersonA = new Person() { FirstName = "Maria", LastName = "Svensson", Age = 29 };
            PersonA.Children.Add(new Person { FirstName = "Kalle", LastName = "Svensson", Age = 5 });
            PersonA.Children.Add(new Person { FirstName = "Anna", LastName = "Svensson", Age = 8 });

            DataContext = PersonA;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PersonA.FirstName = "Melvin";
            PersonA.LastName = "Edlund";
            PersonA.Children.Add(new Person { FirstName = "Thomas", LastName = "Svensson", Age = 3 });

        }
    }
}