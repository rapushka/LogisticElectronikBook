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

namespace LogisticEBook.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page1_7.xaml
    /// </summary>
    public partial class Page1_7 : Page
    {
        public Page1_7()
        {
            InitializeComponent();
        }

		private void OpenPopUp(object sender, MouseButtonEventArgs e)
		{
            PopUp.ShowInAppsViewer(sender);
		}
	}
}