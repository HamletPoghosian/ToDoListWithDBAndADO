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
        #region DBforToDoList property
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
        #endregion 

        #region DBforToDoList InsertMethods
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
        #endregion

        #region DBforToDoList SelectMethods
        /// <summary>
        /// Select DB All Tasks . 
        /// </summary>
        public List<MyTask> Select()
        {
            MyTask taskValue;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                List<MyTask> tasks = new List<MyTask>();
                string selectQuery = @"SELECT Id, TaskDescription, IsComletid FROM[Task]";
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        taskValue = new MyTask();
                        taskValue.Id = int.Parse(reader[0].ToString());
                        taskValue.Mywork = reader[1].ToString();
                        taskValue.Isdone =Boolean.Parse(reader[2].ToString());
                        tasks.Add(taskValue);
                    }
                }
                return tasks;
            }

        }
        /// <summary>
        /// Select DB All Tasks . 
        /// </summary>
        public List<MyTask> Select(string taskDesc)
        {
            MyTask taskValue;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                List<MyTask> tasks = new List<MyTask>();
                string selectQuery = @"SELECT Id, TaskDescription, IsComletid FROM[Task] WHERE TaskDescription='"+taskDesc+"' ";
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        taskValue = new MyTask();
                        taskValue.Id = int.Parse(reader[0].ToString());
                        taskValue.Mywork = reader[1].ToString();
                        taskValue.Isdone = Boolean.Parse(reader[2].ToString());
                        tasks.Add(taskValue);
                    }
                }
                return tasks;
            }

        }
        /// <summary>
        /// Select DB IsComletid  or NotComletid Tasks in Int Value  . 
        /// 0-IsComletid  1-Not Comletid     </summary>
        public List<MyTask> Select(int taskDesc)
        {
            MyTask taskValue;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                List<MyTask> tasks = new List<MyTask>();
                string selectQuery = @"SELECT  TaskDescription, IsComletid FROM[Task] WHERE IsComletid='" + taskDesc + "' ";
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        taskValue = new MyTask();                       
                        taskValue.Mywork = reader[1].ToString();
                        taskValue.Isdone = Boolean.Parse(reader[2].ToString());
                        tasks.Add(taskValue);
                    }
                }
                return tasks;
            }

        }
        #endregion

        #region DBforToDoList UpdateMethods
        /// <summary>
        /// Update DB Tasks in Id. 
        /// </summary>
        public void Update(int usersId,MyTask taskDesc)
        {
            string updateQuery = @"UPDATE [Task] SET TaskDescription=@TaskDescription,IsComletid=@IsComletid Where Id = '" + usersId + "'";
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    connection.Open();
                    command.Parameters.Add(new SqlParameter("TaskDescription", taskDesc.Mywork));
                    command.Parameters.Add(new SqlParameter("IsComletid", taskDesc.Isdone));
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        /// <summary>
        /// Update DB Tasks in TaskDescription . 
        /// </summary>
        public void Update(string taskDescript)
        {
            string updateQuery = @"UPDATE [Task] SET IsComletid=@IsComletid Where TaskDescription = '" + taskDescript + "'";
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    connection.Open();                    
                    command.Parameters.Add(new SqlParameter("IsComletid", true));
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        #endregion

        #region DBforToDoList DeleteMethods
        /// <summary>
        /// Delete DB All Tasks  . 
        /// </summary>
        public void Delete()
        {
            string deleteQuery = @"DELETE FROM Task DBCC CHECKIDENT ('[Task]', RESEED, 0)";
            using (SqlConnection connection = new SqlConnection(conectionString))
            {

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    
                    connection.Close();
                }
            }
        }
        /// <summary>
        /// Delete DB by TaskDescription  . 
        /// </summary>
        public void Delete(string tasdesc)
        {
            string deleteQuery = @"DELETE FROM [Task]  Where TaskDescription='"+tasdesc+"'";
            using (SqlConnection connection = new SqlConnection(conectionString))
            {

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        /// <summary>
        /// Delete DB by Completed  . 
        /// </summary>
        public void Delete(bool Completed)
        {
            string deleteQuery = @"DELETE FROM [Task]  Where IsComletid='" + Completed + "'";
            using (SqlConnection connection = new SqlConnection(conectionString))
            {

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        #endregion
    }
}
