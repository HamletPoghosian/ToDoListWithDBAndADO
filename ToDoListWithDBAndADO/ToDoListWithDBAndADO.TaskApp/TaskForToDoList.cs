using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Lib;

namespace ToDoListWithDBAndADO.TaskApp
{
    public partial class TaskForToDoList : Form
    {
        DBforToDoList db = new DBforToDoList(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ToDoListDatas;Integrated Security=true;");
        public TaskForToDoList()
        {
            InitializeComponent();
        }
        #region AddButton InsertDBAddValue
        private void ButtonAddTask_Click(object sender, EventArgs e)
        {

            checkedListBoxTask.Items.Add(textBoxTaskDescription.Text);
            db.Insert(new MyTask(textBoxTaskDescription.Text));
            textBoxTaskDescription.Text = string.Empty;
        }
        #endregion
        #region UpdateChechkd Value 
        private void checkedListBoxTask_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string myTask = checkedListBoxTask.SelectedItem.ToString();
            textBoxTaskDescription.Text = myTask;
            db.Update(myTask);
        }
        #endregion
        #region ComboBoxSearch ComboBoxSearchEvent
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            string searchBy = comboBox1.SelectedItem.ToString();
            switch (searchBy)
            {
                case "By Id":
                    {

                        break;
                    }
                case "By TaskDescription":
                    {
                        List<MyTask> m = db.Select(textBoxTaskDescription.Text);
                        for (int i = 0; i < m.Count; i++)
                        {
                            checkedListBoxTask.Items.Add(m[i]);
                        }
                        break;
                    }
                case "By Completed":
                    {
                        break;
                    }
                case "All":
                    {
                        List<MyTask> m = db.Select();
                        for (int i = 0; i < m.Count; i++)
                        {
                           checkedListBoxTask.Items.Add(m[i]);
                        }
                       
                        MessageBox.Show("This is Task for DataBase");
                        break;
                    }
                default:
                    {

                        break;
                    }
            }
        }
        #endregion
        #region ComboBoxDelete ComboBoxDeleteEvent
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchBy = comboBox2.SelectedItem.ToString();
            switch (searchBy)
            {
                case "By Id":
                    {
                        
                        break;
                    }
                case "By TaskDescription":
                    {
                        string taskDesc = textBoxTaskDescription.Text;
                        db.Delete(taskDesc);
                        break;
                    }
                case "By Completed":
                    {

                        break;
                    }
                case "All":
                    {
                        db.Delete();
                        checkedListBoxTask.Items.Clear();
                        MessageBox.Show("Delete All Value from DataBase ");
                        break;
                    }
                default:
                    {

                        break;
                    }
            }
        }
        #endregion
    }
}
