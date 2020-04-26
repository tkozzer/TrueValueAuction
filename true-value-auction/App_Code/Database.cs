using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace truevalueauction.App_Code
{
    public class Database
    {
        private static string conString = ConfigurationManager.ConnectionStrings["Users"].ConnectionString;


        public static void InsertUser(User user)
        {
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(conString);
                var insert = String.Format("INSERT INTO [Users] ([FirstName], [Email], [Password], [RegisterDate]) VALUES ('{0}', '{1}', '{2}', '{3}')", user.GetFirstName(), user.GetEmail(), user.GetPassword(), DateTime.Now);
                SqlCommand cmd = new SqlCommand(insert, con);
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception();

            }
            finally
            {
                con.Close();
            }
        }

        public static bool ValidateUser(User user)
        {
            SqlCommand cmd;
            bool valid = false;

            SqlConnection con = new SqlConnection(conString);

            string sql = string.Format("SELECT [UserId] from [Users] WHERE [Email] = '{0}' AND [Password] = '{1}'", user.GetEmail(), user.GetPassword());
            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                Int32 value = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                if(value == 0)
                {
                    throw new Exception("Please enter a valid email/password");
                }

                valid = true;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
                
            }
            finally
            {
                con.Close();
                
            }
            return valid;

        }

        public static bool UserExists(User user)
        {
            bool exists = false;
            SqlCommand cmd;

            SqlConnection con = new SqlConnection(conString);

            string sql = string.Format("SELECT [UserId] from [Users] WHERE [Email] = '{0}'", user.GetEmail());
            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                Int32 value = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                if (value != 0)
                {
                    exists = true;
                } else
                {
                    exists = false;
                }

                
            }
            catch (Exception ex)
            {
                exists = false;

            }
            finally
            {
                con.Close();

            }
            return exists;

        }

        public static Int32 UserId(User user)
        {
            Int32 userId;
            SqlCommand cmd;

            SqlConnection con = new SqlConnection(conString);

            string sql = string.Format("SELECT [UserId] from [Users] WHERE [Email] = '{0}'", user.GetEmail());
            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                userId = Convert.ToInt32(cmd.ExecuteScalar());


            }
            catch (Exception ex)
            {
                userId = 0;

            }
            finally
            {
                con.Close();

            }
            return userId;
        }




    }
}