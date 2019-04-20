﻿using System;
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

        private void ButtonAddTask_Click(object sender, EventArgs e)
        {

            checkedListBoxTask.Items.Add(textBoxTaskDescription.Text);

            db.Insert(new MyTask(textBoxTaskDescription.Text));
            textBoxTaskDescription.Text = string.Empty;
        }

        private void checkedListBoxTask_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string myTask = checkedListBoxTask.SelectedItem.ToString();
            textBoxTaskDescription.Text = myTask;
            db.Update(myTask);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }



        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

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
                        break;
                    }
                default:
                    {

                        break;
                    }
            }
        }
    }
}