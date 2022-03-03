﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace LogisticEBook
{
	/// <summary>
	/// Логика взаимодействия для PresentationViewer.xaml
	/// </summary>
	public partial class PresentationViewer : Window
	{
		public PresentationViewer(string path)
		{
			OpenPresentation(path);
		}

		private void OpenPresentation(string path)
		{
			path = System.IO.Directory.GetCurrentDirectory()
				+ path;

			try
			{
				ProcessStartInfo processStartInfo = new(path)
				{
					UseShellExecute = true,
				};
				Process.Start(processStartInfo);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
