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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         /*   var login = Login.Text;
            var password = Password.Text;
            var context = new AppDbContext();
            var email = Login.Text;
            var user = context.Users.SingleOrDefault(x => x.Login == login || x.Email == email && x.Password == password);



            if (user is null)
            {
                Login.BorderBrush = new SolidColorBrush(Colors.Red);
                Password.BorderBrush = new SolidColorBrush(Colors.Red);
                MessageBox.Show("Неправильное имя или пароль!");
                return;
            }



            MessageBox.Show("Вы успешно вошли в аккаунт!"); */
        }

        private void Login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 secondWindow = new Window1();
            secondWindow.Show();
        }
    }
}
