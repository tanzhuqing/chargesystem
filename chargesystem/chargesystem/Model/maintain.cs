using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chargesystem.Model
{
    class maintain
    {

        private string m_id;
        public string getMID()
        {
            return this.m_id;
        }
        public void setMID(string id)
        {
            this.m_id = id;
        }
        private string m_time;

        public string getTime(){
           return this.m_time;
        }
        public void setTime(string time)
        {
            this.m_time = time;
        }

        private string m_name;

        public string getName()
        {
            return this.m_name;
        }
        public void setName(string name)
        {
            this.m_name = name;
        }
        private string m_address;

        public string getAddress()
        {
            return this.m_address;
        }
        public void setAddress(string address)
        {
            this.m_address = address;
        }
        private string m_type;

        public string getType()
        {
            return this.m_type;
        }
        public void setType(string type)
        {
            this.m_type = type;
        }
        private string m_text;

        public string getText()
        {
            return this.m_text;
        }
        public void setText(string text)
        {
            this.m_text = text;
        }
        private string m_state;

        public string getState()
        {
            return this.m_state;
        }
        public void setState(string state)
        {
            this.m_state = state;
        }
        private string m_worker;

        public string getWorker()
        {
          return this.m_worker;
        }
        public void setWorker(string worker)
        {
            this.m_worker = worker;
        }
        private string m_feederivate;

        public string getFeederivate()
        {
           return this.m_feederivate;
        }
        public void setFeederivate(string feede)
        {
            this.m_feederivate = feede;
        }
        private string m_fee;

        public string getFee()
        {
            return this.m_fee;
        }
        public void setFee(string fee)
        {
            this.m_fee = fee;
        }
        public maintain(string time, string name, string address, string type, string text, string state, string worker, string feederivate, string fee)
        {
            this.m_time = time;
            this.m_name = name;
            this.m_address = address;
            this.m_text = text;
            this.m_type = type;
            this.m_worker = worker;
            this.m_state = state;
            this.m_feederivate = feederivate;
            this.m_fee = fee;
       
        }

    }
}
