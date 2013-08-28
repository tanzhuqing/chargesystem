using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chargesystem.model
{
    class complaint
    {
        public void complaint(DateTime t,string n,string a,int tel, int ty,string te,string s)
        {
            this.c_time = t;
            this.c_name = n;
            this.c_address = a;
            this.c_tel = tel;
            this.c_type = ty;
            this.c_text = te;
            this.c_state = s;
        
        }

        public void compalaint()
        {
           
   
        }
        private DateTime c_time;

        public DateTime Time
        {
            get { return c_time; }
            set { c_time = value; }
        }
        private string c_name;

        public string Name
        {
            get { return c_name; }
            set { c_name = value; }
        }
        private string c_address;

        public string Address
        {
            get { return c_address; }
            set { c_address = value; }
        }
        private int c_tel;

        public int Tel
        {
            get { return c_tel; }
            set { c_tel = value; }
        }
        private int c_type;

        public int Type
        {
            get { return c_type; }
            set { c_type = value; }
        }
        private string c_text;

        public string Text
        {
            get { return c_text; }
            set { c_text = value; }
        }
        private string c_state;

        public string State
        {
            get { return c_state; }
            set { c_state = value; }
        }
    }
}
