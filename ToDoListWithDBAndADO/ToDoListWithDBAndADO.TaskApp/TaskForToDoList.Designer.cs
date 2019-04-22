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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.ButtonAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ButtonAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonAddTask.Location = new System.Drawing.Point(454, 100);
            this.ButtonAddTask.Name = "ButtonAddTask";
            this.ButtonAddTask.Size = new System.Drawing.Size(197, 54);
            this.ButtonAddTask.TabIndex = 1;
            this.ButtonAddTask.Text = "Add Task";
            this.ButtonAddTask.UseVisualStyleBackColor = false;
            this.ButtonAddTask.Click += new System.EventHandler(this.ButtonAddTask_Click);
            // 
            // checkedListBoxTask
            // 
            this.checkedListBoxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.checkedListBoxTask.FormattingEnabled = true;
            this.checkedListBoxTask.Location = new System.Drawing.Point(36, 164);
            this.checkedListBoxTask.Name = "checkedListBoxTask";
            this.checkedListBoxTask.Size = new System.Drawing.Size(615, 256);
            this.checkedListBoxTask.TabIndex = 2;
            this.checkedListBoxTask.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxTask_ItemCheck);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "By Id",
            "By TaskDescription",
            "By Completed",
            "All"});
            this.comboBox1.Location = new System.Drawing.Point(104, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 5;
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
            this.comboBox2.Location = new System.Drawing.Point(104, 133);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(108, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(33, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(33, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Delete By";
            // 
            // TaskForToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

