using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace chargesystem
{
	/// <summary>
	/// LoginForm.xaml 的交互逻辑
	/// </summary>
	public partial class LoginForm : Window
	{
		public LoginForm()
		{
			this.InitializeComponent();
			
			// 在此点之下插入创建对象所需的代码。
		}

		private void login(object sender, System.Windows.RoutedEventArgs e)
		{
			MainWindow main = new MainWindow();
			main.Show();
			this.Close();
		}

		private void cancel(object sender, System.Windows.RoutedEventArgs e)
		{
			this.Close();
		}
	}
}