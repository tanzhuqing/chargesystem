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
using System.Collections;
using chargesystem.Control;

namespace chargesystem
{
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            // 在此点下面插入创建对象所需的代码。
        }

        private void close(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Close();
        }

        private void openAddHouseholdForm(object sender, System.Windows.RoutedEventArgs e)
        {
            AddHouseholdForm addHouseholdForm = new AddHouseholdForm();
            addHouseholdForm.ShowDialog();
        }

        private void openSearchHouseholdFrom(object sender, System.Windows.RoutedEventArgs e)
        {
            SearchHouseholdForm searchHouseholdForm = new SearchHouseholdForm();
            searchHouseholdForm.ShowDialog();
        }

        private void openAddComplaintForm(object sender, System.Windows.RoutedEventArgs e)
        {
            AddComplaints addComplaint = new AddComplaints();
            addComplaint.ShowDialog();
        
        }

        private void openSearchComplaintForm(object sender, System.Windows.RoutedEventArgs e)
       {
           SearchComplaintsForm searchComplaintForm = new SearchComplaintsForm();
           searchComplaintForm.ShowDialog();
        }

        private void openAddMaintainForm(object sender, System.Windows.RoutedEventArgs e)
        {
            AddMaintainForm addMaintain = new AddMaintainForm();
            addMaintain.ShowDialog();
        }

        private void openSearchMaintainForm(object sender, System.Windows.RoutedEventArgs e)
        {
            SearchMaintainForm searchMaintain = new SearchMaintainForm();
            searchMaintain.ShowDialog();
        }
        private void openAddSuggestionForm(object sender, System.Windows.RoutedEventArgs e)
        {
            AddSuggestionForm addSuggestion = new AddSuggestionForm();
            addSuggestion.ShowDialog();
        
        }

        private void openSearchSuggestionForm(object sender, System.Windows.RoutedEventArgs e)
        {
            SearchSuggestionForm searchSuggestion = new SearchSuggestionForm();
            searchSuggestion.ShowDialog();
        }

        private void openSearchHeatForm(object sender, System.Windows.RoutedEventArgs e)
        {
            SearchHeatForm searchHeat = new SearchHeatForm();
            searchHeat.ShowDialog();
        }

        private void openAddHeatFrom(object sender, System.Windows.RoutedEventArgs e)
        {
            AddHeatForm addHeat = new AddHeatForm();
            addHeat.ShowDialog();
        }
        private void openMaintainChargeForm(object sender, System.Windows.RoutedEventArgs e)
        {
            MaintainChargeForm maintainCharge = new MaintainChargeForm();
            maintainCharge.ShowDialog();
        }
        private void openMaintainWorkerForm(object sender, System.Windows.RoutedEventArgs e)
        {
            MaintainWorkerForm maintainWorker = new MaintainWorkerForm();
            maintainWorker.ShowDialog();
          
        }
        private void showHouseholdInformation(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (this.indexPage.IsVisible == true)
                this.indexPage.Visibility = System.Windows.Visibility.Hidden;
            else if (this.chargeManage.IsVisible == true)
                this.chargeManage.Visibility = System.Windows.Visibility.Hidden;
            else if (this.ComplaintsManagement.IsVisible == true)
                this.ComplaintsManagement.Visibility = System.Windows.Visibility.Hidden;
            else if (this.Installation.IsVisible == true)
                this.Installation.Visibility = System.Windows.Visibility.Hidden;
            else if (this.MaintainManagement.IsVisible == true)
                this.MaintainManagement.Visibility = System.Windows.Visibility.Hidden;

            this.baseInformation.Visibility = System.Windows.Visibility.Visible;
            this.baseInformation.SelectedIndex = 0;
        }

        private void showInstrumentInformation(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (this.indexPage.IsVisible == true)
                this.indexPage.Visibility = System.Windows.Visibility.Hidden;
            else if (this.chargeManage.IsVisible == true)
                this.chargeManage.Visibility = System.Windows.Visibility.Hidden;
            else if (this.ComplaintsManagement.IsVisible == true)
                this.ComplaintsManagement.Visibility = System.Windows.Visibility.Hidden;
            else if (this.Installation.IsVisible == true)
                this.Installation.Visibility = System.Windows.Visibility.Hidden;
            else if (this.MaintainManagement.IsVisible == true)
                this.MaintainManagement.Visibility = System.Windows.Visibility.Hidden;

            this.baseInformation.Visibility = System.Windows.Visibility.Visible;
            this.baseInformation.SelectedIndex = 1;
        }

        private void showConstructionInformation(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (this.indexPage.IsVisible == true)
                this.indexPage.Visibility = System.Windows.Visibility.Hidden;
            else if (this.chargeManage.IsVisible == true)
                this.chargeManage.Visibility = System.Windows.Visibility.Hidden;
            else if (this.ComplaintsManagement.IsVisible == true)
                this.ComplaintsManagement.Visibility = System.Windows.Visibility.Hidden;
            else if (this.Installation.IsVisible == true)
                this.Installation.Visibility = System.Windows.Visibility.Hidden;
            else if (this.MaintainManagement.IsVisible == true)
                this.MaintainManagement.Visibility = System.Windows.Visibility.Hidden;

            this.baseInformation.Visibility = System.Windows.Visibility.Visible;
            this.baseInformation.SelectedIndex = 2;
        }

       

        private void openSingleChargeManage(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (this.baseInformation.IsVisible == true)
                this.baseInformation.Visibility = System.Windows.Visibility.Hidden;
            else if (this.indexPage.IsVisible == true)
                this.indexPage.Visibility = System.Windows.Visibility.Hidden;
            else if (this.ComplaintsManagement.IsVisible == true)
                this.ComplaintsManagement.Visibility = System.Windows.Visibility.Hidden;
            else if (this.Installation.IsVisible == true)
                this.Installation.Visibility = System.Windows.Visibility.Hidden;
            else if (this.MaintainManagement.IsVisible == true)
                this.MaintainManagement.Visibility = System.Windows.Visibility.Hidden;

            this.chargeManage.Visibility = System.Windows.Visibility.Visible;
            this.chargeManage.SelectedIndex = 0;
        }

        private void searchHousehold(object sender, System.Windows.RoutedEventArgs e)
        {
            Household hh = new Household { Id = "1", Name = "zouguozhu" };
            List<Household> householdData = new List<Household>();
            householdData.Add(hh);
            householdData.Add(new Household { Id = "2", Name = "邹国柱" });
            this.householdgrid.DataContext = householdData;

        }

        
        private void searchMaintainer(object sender, System.Windows.RoutedEventArgs e)
        {
           /* MaintainForm mf = new MaintainForm();
            mf.M_Fee = 192.50;
            mf.M_Feederivate = "公司";
            mf.M_Name = "李刚";
            mf.M_State = "未处理";
            mf.M_Text = "暖气有时热有时不热";
            mf.M_Time = "2011年3月1号";
            mf.M_Type = "供暖设备质量问题";
           List<MaintainForm> maintainformData = new List<MaintainForm>();
            maintainformData.Add(mf);
            this.MaintainForm.DataContext = maintainformData;*/
            maintainCon mc = new maintainCon();
            
            
        
        }
        private void chargeForm(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ChargeForm chargeForm = new ChargeForm();
            chargeForm.ShowDialog();
        }



        private void showComplaints(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (this.indexPage.IsVisible == true)
                this.indexPage.Visibility = System.Windows.Visibility.Hidden;
            else if (this.baseInformation.IsVisible == true)
                this.baseInformation.Visibility = System.Windows.Visibility.Hidden;
            else if (this.chargeManage.IsVisible == true)
                this.chargeManage.Visibility = System.Windows.Visibility.Hidden;
            else if (this.Installation.IsVisible == true)
                this.Installation.Visibility = System.Windows.Visibility.Hidden;
            else if (this.MaintainManagement.IsVisible == true)
                this.MaintainManagement.Visibility = System.Windows.Visibility.Hidden;

            this.ComplaintsManagement.Visibility = System.Windows.Visibility.Visible;
            this.ComplaintsManagement.SelectedIndex = 0;
        }

        private void showSuggestion(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (this.indexPage.IsVisible == true)
                this.indexPage.Visibility = System.Windows.Visibility.Hidden;
            else if (this.baseInformation.IsVisible == true)
                this.baseInformation.Visibility = System.Windows.Visibility.Hidden;
            else if (this.chargeManage.IsVisible == true)
                this.chargeManage.Visibility = System.Windows.Visibility.Hidden;
            else if (this.Installation.IsVisible == true)
                this.Installation.Visibility = System.Windows.Visibility.Hidden;
            else if (this.MaintainManagement.IsVisible == true)
                this.MaintainManagement.Visibility = System.Windows.Visibility.Hidden;

            this.ComplaintsManagement.Visibility = System.Windows.Visibility.Visible;
            this.ComplaintsManagement.SelectedIndex = 1;
        }

        private void showComplaintsInformation(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (this.indexPage.IsVisible == true)
                this.indexPage.Visibility = System.Windows.Visibility.Hidden;
            else if (this.baseInformation.IsVisible == true)
                this.baseInformation.Visibility = System.Windows.Visibility.Hidden;
            else if (this.chargeManage.IsVisible == true)
                this.chargeManage.Visibility = System.Windows.Visibility.Hidden;

            this.ComplaintsManagement.Visibility = System.Windows.Visibility.Visible;
            this.ComplaintsManagement.SelectedIndex = 2;
        }

        private void showMaintainManagement(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (this.indexPage.IsVisible == true)
                this.indexPage.Visibility = System.Windows.Visibility.Hidden;
            else if (this.baseInformation.IsVisible == true)
                this.baseInformation.Visibility = System.Windows.Visibility.Hidden;
            else if (this.chargeManage.IsVisible == true)
                this.chargeManage.Visibility = System.Windows.Visibility.Hidden;
            else if (this.ComplaintsManagement.IsVisible == true)
                this.ComplaintsManagement.Visibility = System.Windows.Visibility.Hidden;
            else if (this.Installation.IsVisible == true)
                this.Installation.Visibility = System.Windows.Visibility.Hidden;

            this.MaintainManagement.Visibility = System.Windows.Visibility.Visible;
            this.ComplaintsManagement.SelectedIndex = 0;
        }

        private void showInstallManagement(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (this.indexPage.IsVisible == true)
                this.indexPage.Visibility = System.Windows.Visibility.Hidden;
            else if (this.baseInformation.IsVisible == true)
                this.baseInformation.Visibility = System.Windows.Visibility.Hidden;
            else if (this.chargeManage.IsVisible == true)
                this.chargeManage.Visibility = System.Windows.Visibility.Hidden;
            else if (this.ComplaintsManagement.IsVisible == true)
                this.ComplaintsManagement.Visibility = System.Windows.Visibility.Hidden;
            else if (this.MaintainManagement.IsVisible == true)
                this.MaintainManagement.Visibility = System.Windows.Visibility.Hidden;

            this.Installation.Visibility = System.Windows.Visibility.Visible;
            this.Installation.SelectedIndex = 0;
        }

       

    }
}