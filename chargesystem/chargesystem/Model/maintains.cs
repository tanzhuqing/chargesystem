using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using chargesystem.Util;

namespace chargesystem.Model
{
    class Maintains
    {
        private List<maintain> maintains;
        public Maintains()
        {
            maintains = new List<maintain>();
            DatabaseUtil dbu = new DatabaseUtil();
           
            string sql = "select * from t_maintainForm";
            dbu.Open();
            SqlDataReader dr = dbu.Query(sql);
            while (dr.Read())
            {
                maintain mt= new maintain(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(),dr[9].ToString());
                maintains.Add(mt);
            }
            dbu.Close();
        }

        public void AddMaintain(maintain m)
        {
            maintains.Add(m);
            DatabaseUtil dbu = new DatabaseUtil();
            string sql = "insert into t_maintainForm values "+m.getTime()+","+m.getName()+","+m.getAddress()+","+m.getType()+","+m.getText()+","+m.getState()+","+m.getWorker()+","+m.getFeederivate()+","+m.getFee()+")";
            dbu.Open();
            dbu.Excute(sql);
            dbu.Close();
        }

        public void RemoveMaintain(maintain m)
        {
            maintains.Remove(m);
            DatabaseUtil dbu = new DatabaseUtil();
            string sql = "delete from t_maintainForm where id=" + m.getMID();
            dbu.Open();
            dbu.Excute(sql);
            dbu.Close();
        }
      
    }
}


/*
class Users
{
    private List<User> users;//user集合对象
   
   
    public User getUserById(string id)
    {
        User user = null;
        foreach (User u in users)
        {
            if (u.GetId() == id)
                user = u;
        }
        return user;
    }
    public User getUserByName(string name)
    {
        User user = null;
        foreach (User u in users)
        {
            if (u.GetName() == name)
                user = u;
        }
        return user;
    }
    public int Size()//返回集合元素个数
    {
        return users.Count();
    }
    public void clear()//清空集合，并更新到数据库
    {
        users.Clear();

        SQLServer sqlserver = new SQLServer("localhost", "sa", "1234", "meterread");
        string sql = "delete from  tuser";
        sqlserver.Open();
        sqlserver.Excute(sql);
        sqlserver.Close();
    }
}
*/