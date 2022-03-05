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
    /// Логика взаимодействия для Page4_2.xaml
    /// </summary>
    public partial class Page4_2 : Page
    {
        public Page4_2()
        {
            InitializeComponent();
        }

		private void OpenPopUp(object sender, MouseButtonEventArgs e)
		{
            PopUp.ShowInAppsViewer(sender);
		}
	}
}