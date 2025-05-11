using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace 点餐管理系统
{
    internal class userserive
    {
        public bool CheckCustomer(string username,string pwd)
        {
            //pwd=GetMd5Hash.MD5(pwd)
            bool flag = false;
            DB.GetCn();
            string str = "select * from customers where Customers_Name=@username and Customers_Password=@pwd";
            SqlCommand cmd = new SqlCommand(str, DB.cn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            try
            {
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    flag = true;
                    Login.Customers_id = rdr[0].ToString();
                }
            }
            catch(SqlException ex)
            {
                throw;
            }
            finally
            {
                DB.cn.Close();
            }
            return flag;
        }
        public bool checkEmployee(string username,string pwd)
        {
            //pwd=GetMd5Hash.MD5(pwd);
            bool flag = false;
            DB.GetCn();
            string str = "select * from employee where employee_Name=@username and employee_Password=@pwd";
            SqlCommand cmd = new SqlCommand(str, DB.cn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            try
            {
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    flag = true;
                    Login.employee_id = rdr[0].ToString();
                }
            }
            catch(SqlException ex)
            {
                throw;
            }
            finally
            {
                DB.cn.Close();
            }
            return flag;
        }
        public bool checkUser(string username,string pwd,int keys)
        {
            //pwd=GetMd5Hash.MD5(pwd);
            bool flag = false;
            DB.GetCn();
            string str = "select * from user where username=@username and pwd=@pwd and keys=@keys";
            SqlCommand cmd = new SqlCommand(str, DB.cn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            cmd.Parameters.AddWithValue("@keys", keys);
            try
            {
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    flag = true;
                    Login.employee_id = rdr[0].ToString();
                }
            }
            catch(SqlException ex)
            {
                throw;
            }
            finally
            {
                DB.cn.Close();
            }
            return flag;
        }
    }
}
