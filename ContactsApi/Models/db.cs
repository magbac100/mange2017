using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace ContactsApi.Models
{
    public class db
    {
        public string db1(int id)
        {
            string i = "";
            MySqlConnection con;
            string myConnectionString = "server=127.0.0.1;uid=root;pwd=lasslass;database=mb";
            //string myConnectionString = "server=192.168.0.19;uid=mange;pwd=lasslass;database=MANGE";
            try
            {
                con = new MySqlConnection();
                con.ConnectionString = myConnectionString;
                con.Open();
                MySqlCommand msqlCommand = new MySqlCommand();
                //define the connection used by the command object
                //msqlCommand.Connection ;
                //define the command text
                msqlCommand.CommandText = "SELECT FirstName FROM User where id=" + id;
                //msqlCommand.CommandText = "SELECT name FROM test where age=" + id;
                msqlCommand.Connection = con;
                
                MySqlDataReader msqlReader = msqlCommand.ExecuteReader();
                while (msqlReader.Read())
                {
                    i = msqlReader.GetValue(0).ToString();
                }
            }
            catch (MySqlException ex)
            {

            }
            finally
            {
                
            }
            return i;
        }
    }
}