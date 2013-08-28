using System;
using System.Collections.Generic;
using System.Linq;
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
    /// PrintComplaintForm.xaml 的交互逻辑
    /// </summary>
    public partial class PrintComplaintForm : Window
    {
        public PrintComplaintForm()
        {
            InitializeComponent();
        }
        private void closeForm(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
