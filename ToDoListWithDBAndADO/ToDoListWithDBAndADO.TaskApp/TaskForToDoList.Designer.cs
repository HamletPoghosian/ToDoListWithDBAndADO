namespace ToDoListWithDBAndADO.TaskApp
{
    partial class TaskForToDoList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxTaskDescription = new System.Windows.Forms.TextBox();
            this.ButtonAddTask = new System.Windows.Forms.Button();
            this.checkedListBoxTask = new System.Windows.Forms.CheckedListBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxTaskDescription
            // 
            this.textBoxTaskDescription.Location = new System.Drawing.Point(36, 12);
            this.textBoxTaskDescription.Multiline = true;
            this.textBoxTaskDescription.Name = "textBoxTaskDescription";
            this.textBoxTaskDescription.Size = new System.Drawing.Size(615, 82);
            this.textBoxTaskDescription.TabIndex = 0;
            // 
            // ButtonAddTask
            // 
            this.ButtonAddTask.Location = new System.Drawing.Point(454, 100);
            this.ButtonAddTask.Name = "ButtonAddTask";
            this.ButtonAddTask.Size = new System.Drawing.Size(197, 54);
            this.ButtonAddTask.TabIndex = 1;
            this.ButtonAddTask.Text = "Add Task";
            this.ButtonAddTask.UseVisualStyleBackColor = true;
            this.ButtonAddTask.Click += new System.EventHandler(this.ButtonAddTask_Click);
            // 
            // checkedListBoxTask
            // 
            this.checkedListBoxTask.FormattingEnabled = true;
            this.checkedListBoxTask.Location = new System.Drawing.Point(36, 164);
            this.checkedListBoxTask.Name = "checkedListBoxTask";
            this.checkedListBoxTask.Size = new System.Drawing.Size(615, 274);
            this.checkedListBoxTask.TabIndex = 2;
            this.checkedListBoxTask.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxTask_ItemCheck);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(251, 100);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(197, 27);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "Delete Task";
            this.buttonDel.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(36, 100);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(197, 27);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "By Id",
            "By TaskDescription",
            "By Completed",
            "All"});
            this.comboBox1.Location = new System.Drawing.Point(36, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "By Id",
            "By TaskDescription",
            "By Completed",
            "All"});
            this.comboBox2.Location = new System.Drawing.Point(251, 133);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(197, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // TaskForToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.checkedListBoxTask);
            this.Controls.Add(this.ButtonAddTask);
            this.Controls.Add(this.textBoxTaskDescription);
            this.Name = "TaskForToDoList";
            this.Text = "LoDoList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTaskDescription;
        private System.Windows.Forms.Button ButtonAddTask;
        private System.Windows.Forms.CheckedListBox checkedListBoxTask;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

