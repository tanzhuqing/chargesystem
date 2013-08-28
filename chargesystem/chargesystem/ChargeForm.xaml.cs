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
	/// ChargeForm.xaml 的交互逻辑
	/// </summary>
	public partial class ChargeForm : Window
	{
		public ChargeForm()
		{
			this.InitializeComponent();
			
			// 在此点之下插入创建对象所需的代码。
		}

		private void charge(object sender, System.Windows.RoutedEventArgs e)
		{
			chargeresponse cr = new chargeresponse();
			this.Close();
			cr.Show();
		}
	}
}