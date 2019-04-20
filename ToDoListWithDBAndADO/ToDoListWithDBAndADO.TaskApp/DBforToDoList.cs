using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Lib;

namespace ToDoListWithDBAndADO.TaskApp
{
    public class DBforToDoList
    {
        private string conectionString = string.Empty;
        public string ConString
        {
            get
            {
                return conectionString;
            }
             set
            {
                conectionString = value;
            }
        }
        public DBforToDoList()
        {

        }
        public DBforToDoList(string constring)
        {
            ConString = constring;
        }
        /// <summary>
        /// Insert DB Tasks. 
        /// </summary>
        public void Insert(MyTask task)
        {
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                string insertQuery = @"INSERT INTO [Task] VALUES(@TaskDescription,@IsComletid)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    connection.Open();
                    
                    command.Parameters.Add(new SqlParameter("TaskDescription", task.Mywork));
                    command.Parameters.Add(new SqlParameter("IsComletid", task.Isdone));
                   
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        //public List<Users> Select(Users us)
        //{
        //    using (SqlConnection connection = new SqlConnection(conectionString))
        //    {
        //        List<Users> users = new List<Users>();
        //        string selectQuery = @"SELECT Id, Name, LastName, Solary FROM[Table]";
        //        connection.Open();
        //        using (SqlCommand command = new SqlCommand(selectQuery, connection))
        //        {
        //            SqlDataReader reader = command.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                us = new Users();
        //                us.Id = int.Parse(reader[0].ToString());
        //                us.Name = reader[1].ToString();
        //                us.Lastname = reader[2].ToString();
        //                us.Solary = int.Parse(reader[3].ToString());
        //                users.Add(us);
        //            }




        //        }
        //        return users;
        //    }

        //}
        //public void Update(Users us, int usersId)
        //{
        //    string updateQuery = @"UPDATE [Table] SET Name = @name,LastName=@lastname,Solary=@solary Where Id = '" + usersId + "'";
        //    using (SqlConnection connection = new SqlConnection(conectionString))
        //    {
        //        using (SqlCommand command = new SqlCommand(updateQuery, connection))
        //        {

        //            connection.Open();

        //            command.Parameters.Add(new SqlParameter("Name", us.Name));
        //            command.Parameters.Add(new SqlParameter("LastName", us.Lastname));
        //            command.Parameters.Add(new SqlParameter("Solary", us.Solary));
        //            command.ExecuteNonQuery();
        //            connection.Close();
        //        }
        //    }
        //}
        //public void Delete(int id)
        //{
        //    string deleteQuery = @"DELETE FROM [Table] WHERE Id='" + id + "'";
        //    using (SqlConnection connection = new SqlConnection(conectionString))
        //    {

        //        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
        //        {
        //            connection.Open();
        //            command.ExecuteNonQuery();
        //            connection.Close();
        //        }
        //    }
        //}
    }
}
