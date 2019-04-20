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
        public TaskForToDoList()
        {
            InitializeComponent();
        }

       

        private void ButtonAddTask_Click(object sender, EventArgs e)
        {
            MyToDoList my = new MyToDoList();
            
            checkedListBoxTask.Items.Add(textBoxTaskDescription.Text);
            DBforToDoList db = new DBforToDoList();
            db.ConString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ToDoListDatas;Integrated Security=true;  ";
            db.Insert(new MyTask(textBoxTaskDescription.Text));
        }

        private void checkedListBoxTask_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           
            
        }
    }
}
