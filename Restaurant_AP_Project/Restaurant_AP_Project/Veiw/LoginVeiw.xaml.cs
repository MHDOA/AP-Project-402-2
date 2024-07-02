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
using System.Windows.Shapes;

namespace Restaurant_AP_Project.Veiw
{
    /// <summary>
    /// Interaction logic for LoginVeiw.xaml
    /// </summary>
    public partial class LoginVeiw : Window
    {
        public LoginVeiw()
        {
            InitializeComponent();
        }

        private void btnLogin(object sender, RoutedEventArgs e)
        {

        }

        private void MouseDownMove(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btnSignUp(object sender, RoutedEventArgs e)
        {
            SignUpVeiw signUpVeiw = new SignUpVeiw();
            signUpVeiw.Show();
            Close();
        }

        private void btnClose(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnMinimize(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }

    
}
