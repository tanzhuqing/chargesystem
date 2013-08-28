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
    class MaintainForm
    {
        public MaintainForm()
        { }

        private string M_time;
        private string M_name;
        private string M_type;
        private string M_state;
        private string M_text;
        private string M_feederivate;
        private double M_fee;

        public string M_Time
        {
            get { return M_time; }
            set { M_time = value; }
        }

        public string M_Name
        {
            get { return M_name; }
            set { M_name = value; }
        }
        public string M_Type
        {
            get { return M_type; }
            set { M_type = value; }
        }
        public string M_State
        {
            get { return M_state; }
            set { M_state = value; }
        }
        public string M_Text
        {
            get { return M_text; }
            set { M_text = value; }
        }
        public string M_Feederivate
        {
            get { return M_feederivate; }
            set { M_feederivate = value; }
        }
        public double M_Fee
        {
            get { return M_fee; }
            set { M_fee = value; }
        }





    }
}
