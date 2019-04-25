using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                try
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
                catch (InvalidCastException )
                {
                    MessageBox.Show("Dont INSERT DB for Error");                    
                }
                catch (SqlException)
                {
                    MessageBox.Show("Dont INSERT DB for Error");
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Dont INSERT DB for Error");
                }
                catch (Exception)
                {
                    throw ;
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
                string selectQuery = @"SELECT TaskDescription, IsComletid FROM[Task]";
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {


                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            taskValue = new MyTask();
                            taskValue.Mywork = reader[0].ToString();
                            taskValue.Isdone = Boolean.Parse(reader[1].ToString());
                            tasks.Add(taskValue);
                        }
                    }
                    return tasks;
                }
                catch (InvalidCastException)
                {
                    MessageBox.Show("Dont INSERT DB for Error");
                    return tasks;
                }
                catch (SqlException)
                {
                    MessageBox.Show("Dont INSERT DB for Error");
                    return tasks;
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Dont INSERT DB for Error");
                    return tasks;

                }
                catch (Exception)
                {

                    throw;
                }
            }

        }
        /// <summary>
        /// Select DB Tasks by TaskDescription . 
        /// </summary>
        public List<MyTask> Select(string taskDesc)
        {
            MyTask taskValue;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                List<MyTask> tasks = new List<MyTask>();
                string selectQuery = @"SELECT  TaskDescription, IsComletid FROM[Task] WHERE TaskDescription='"+taskDesc+"' ";
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        taskValue = new MyTask();                        
                        taskValue.Mywork = reader[0].ToString();
                        taskValue.Isdone = Boolean.Parse(reader[1].ToString());
                        tasks.Add(taskValue);
                    }
                }
                return tasks;
            }

        }
        /// <summary>
        /// Select DB IsComletid  or NotComletid Tasks in Int Value  . 
        /// true-IsComletid  false-Not Comletid     </summary>
        public List<MyTask> Select(bool taskComletidt)
        {
            MyTask taskValue;
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                List<MyTask> tasks = new List<MyTask>();
                string selectQuery = @"SELECT  TaskDescription, IsComletid FROM[Task] WHERE IsComletid='" + taskComletidt + "' ";
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        taskValue = new MyTask();                       
                        taskValue.Mywork = reader[0].ToString();
                        taskValue.Isdone = Boolean.Parse(reader[1].ToString());
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
        /// Delete DB by Completed   
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
