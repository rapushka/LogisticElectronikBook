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

using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace LogisticEBook.Apps
{
	/// <summary>
	/// Логика взаимодействия для Topic1_5TypeOfShelfs.xaml
	/// </summary>
	public partial class Topic1_5TypeOfShelfs : Window
	{
		public Topic1_5TypeOfShelfs()
		{
			InitializeComponent();

			OpenPresentation();
			Close();
		}



		private void OpenPresentation()
		{
			string path = System.IO.Directory.GetCurrentDirectory()
				+ @"/Presentations/Presentation1_5TypeOfShelfs.pptx";

			try
			{
				dynamic app = new PowerPoint.Application();
				app.Presentations.Open2007(path);
			}
			catch
			{
				MessageBox.Show("Ошибка при открытии презентации");
			}
		}
	}
}