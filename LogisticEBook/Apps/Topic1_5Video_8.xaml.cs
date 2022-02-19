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
using System.Windows.Threading;

namespace LogisticEBook.Apps
{
	/// <summary>
	/// Логика взаимодействия для Topic1_5ConsoleRacks.xaml
	/// </summary>
	public partial class Topic1_5Video_8 : Window
	{
		public Topic1_5Video_8()
		{
			InitializeComponent();

			Uri path = new(System.IO.Directory.GetCurrentDirectory()
				+ @"/Resources/1_5/ConsoleRacks.mp4");

			MediaPlayer.Source = path;
		}
		private void ButtonPlay_Click(object sender, RoutedEventArgs e)
		{
			MediaPlayer.Play();
		}

		private void ButtonPause_Click(object sender, RoutedEventArgs e)
		{
			MediaPlayer.Pause();
		}

		private void ButtonStop_Click(object sender, RoutedEventArgs e)
		{
			MediaPlayer.Stop();
		}
	}
}