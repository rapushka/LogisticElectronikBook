﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LogisticEBook
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private void Hyperlink_Click(object sender, RoutedEventArgs e)
		{
			PopUp.ShowInAppsViewer(sender);
		}
	}
}
