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
using System.Data.SqlClient;


namespace chargesystem.util
{
	public class Database
	{
       
              private  SqlConnection connection;
       
        
		
          // SqlConnection  connection;    //声明连接对象

                   public void SQLServer(string address,string userId,string password,string database)//通过构造函数实例化连接对象
                  {
                    /*数据库连接字符串"*/
                       string conStr = "Persist Security Info=True;server=" + address + ";uid=" + userId + ";pwd =" + password + ";database=" + database;
                       connection = new SqlConnection(conStr);
                   }
                    public void Open()
                  {
                    /*数据库打开*/
                     if(connection!=null)
                     connection.Open();
                   }
                    public void Close()
                   {
                    /*数据库关闭*/
                     if (connection != null)
                        connection.Close();
                    }
                    public SqlDataReader Query(string sql)//查询表并返回结果
                    {
                      SqlCommand cmd = connection.CreateCommand();
                      cmd.CommandText = sql;
                      SqlDataReader dr = cmd.ExecuteReader();//专用方法，注意与操纵的区别，dr相当于一个记录集
                      return dr;
                    }
                    public int Excute(string sql)//修改表的方法
                   {
                    int i = 0;//修改数据库影响的行数
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = sql;
                    i = cmd.ExecuteNonQuery();//该方法返回被更新的记录条数
                    return i;
                    }
           
     }
    
}
   

