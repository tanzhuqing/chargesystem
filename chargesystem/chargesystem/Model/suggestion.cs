using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chargesystem.model
{
    class suggestion
    {
        public void suggestion()
        { }

        private DateTime s_time;

        public DateTime Time
        {
            get { return s_time; }
            set { s_time = value; }
        }
        private string s_name;

        public string Name
        {
            get { return s_name; }
            set { s_name = value; }
        }
        private int s_tel;

        public int Tel
        {
            get { return s_tel; }
            set { s_tel = value; }
        }
        private string s_address;

        public string Address
        {
            get { return s_address; }
            set { s_address = value; }
        }
        private int s_type;

        public int Type
        {
            get { return s_type; }
            set { s_type = value; }
        }
        private string s_text;

        public string Text
        {
            get { return s_text; }
            set { s_text = value; }
        }


    }
}
