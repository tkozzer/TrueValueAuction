using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

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

        public static void InsertBid(double bid, int userId, int itemId)
        {
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(conString);
                var insertBid = String.Format("INSERT INTO [Bids] ([UserId], [ItemId], [Amount], [BidTime]) VALUES ('{0}','{1}','{2}','{3}')", userId, itemId, bid, DateTime.Now );
                SqlCommand cmd = new SqlCommand(insertBid, con);
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


        public static void InsertItem(AuctionItem item, int userId)
        {
            SqlConnection con = null;
            string sql = "INSERT INTO [Items] ([ItemName], [Description], [StartingPrice], [AuctionLength], [ImageURL], [DateAdded], [UserId], [ItemCondition]) VALUES (@ItemName, @ItemDesc, @StartPrice, @AuctionLength, @ImageUrl, @DateAdded, @UserId, @ItemCondition)";
            SqlCommand cmd = new SqlCommand(sql);
            con = new SqlConnection(conString);

            cmd.Parameters.Add("@ItemName", System.Data.SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@ItemDesc", System.Data.SqlDbType.NVarChar, -1);
            cmd.Parameters.Add("@StartPrice", System.Data.SqlDbType.Float);
            cmd.Parameters.Add("@AuctionLength", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@ImageUrl", System.Data.SqlDbType.NVarChar, -1);
            cmd.Parameters.Add("@DateAdded", System.Data.SqlDbType.DateTime);
            cmd.Parameters.Add("@UserId", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@ItemCondition", System.Data.SqlDbType.NVarChar, 100);

            cmd.Parameters["@ItemName"].Value = item.GetItemName();
            cmd.Parameters["@ItemDesc"].Value = item.GetItemDesc();
            cmd.Parameters["@StartPrice"].Value = item.GetItemPrice();
            cmd.Parameters["@AuctionLength"].Value = item.GetAuctionLength();
            cmd.Parameters["@ImageUrl"].Value = item.GetFile();
            cmd.Parameters["@DateAdded"].Value = DateTime.Now;
            cmd.Parameters["@UserId"].Value = userId;
            cmd.Parameters["@ItemCondition"].Value = item.GetItemCondition();
            cmd.Connection = con;

            try
            {

                //var insert = String.Format("INSERT INTO [Items] ([ItemName], [Description], [StartingPrice], [AuctionLength], [ImageURL], [DateAdded], [UserId], [ItemCondition]) VALUES ('{0}', '{1}', '{2}', '{3}','{4}', '{5}', '{6}', '{7}')", item.GetItemName(), item.GetItemDesc(), item.GetItemPrice(), item.GetAuctionLength(), item.GetFile(), DateTime.Now, userId, item.GetItemCondition());
                //SqlCommand cmd = new SqlCommand(insert, con);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception();

            }
            finally
            {
                cmd.Connection.Close();
                con.Close();
            }
        }

        public static DataTable SearchItems(string searchQuery)
        {
            SqlConnection con = null;
            DataTable searchResults = new DataTable();

            try
            {
                con = new SqlConnection(conString);
                string query = "SELECT [ItemId], [ItemName], [Description], [StartingPrice], [AuctionLength], [DateAdded] FROM [Items] WHERE [ItemName] LIKE '%"+searchQuery+"%' ORDER BY [DateAdded] DESC, [AuctionLength]";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                searchResults.Load(dr);
            }
            catch (Exception ex)
            {
                throw new Exception();
                
            }
            finally
            {
                con.Close();
            }

            return searchResults;
        }

        public static void DeleteItem(int userId, int itemId)
        {
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(conString);
                var insert = String.Format("DELETE FROM [Items] WHERE [UserId] = {0} AND [ItemId] = {1}", userId, itemId);
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

        public static void DeleteAccount(int userId)
        {
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(conString);
                var insert = String.Format("DELETE FROM [Users] WHERE [UserId] = {0}", userId);
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

    }
}