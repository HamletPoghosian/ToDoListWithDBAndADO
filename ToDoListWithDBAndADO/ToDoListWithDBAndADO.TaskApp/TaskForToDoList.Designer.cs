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
            this.SuspendLayout();
            // 
            // textBoxTaskDescription
            // 
            this.textBoxTaskDescription.Location = new System.Drawing.Point(36, 19);
            this.textBoxTaskDescription.Multiline = true;
            this.textBoxTaskDescription.Name = "textBoxTaskDescription";
            this.textBoxTaskDescription.Size = new System.Drawing.Size(597, 35);
            this.textBoxTaskDescription.TabIndex = 0;
            // 
            // ButtonAddTask
            // 
            this.ButtonAddTask.Location = new System.Drawing.Point(656, 21);
            this.ButtonAddTask.Name = "ButtonAddTask";
            this.ButtonAddTask.Size = new System.Drawing.Size(118, 32);
            this.ButtonAddTask.TabIndex = 1;
            this.ButtonAddTask.Text = "Add Task";
            this.ButtonAddTask.UseVisualStyleBackColor = true;
            this.ButtonAddTask.Click += new System.EventHandler(this.ButtonAddTask_Click);
            // 
            // checkedListBoxTask
            // 
            this.checkedListBoxTask.FormattingEnabled = true;
            this.checkedListBoxTask.Location = new System.Drawing.Point(39, 104);
            this.checkedListBoxTask.Name = "checkedListBoxTask";
            this.checkedListBoxTask.Size = new System.Drawing.Size(734, 304);
            this.checkedListBoxTask.TabIndex = 2;
            this.checkedListBoxTask.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxTask_ItemCheck);
            // 
            // TaskForToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBoxTask);
            this.Controls.Add(this.ButtonAddTask);
            this.Controls.Add(this.textBoxTaskDescription);
            this.Name = "TaskForToDoList";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTaskDescription;
        private System.Windows.Forms.Button ButtonAddTask;
        private System.Windows.Forms.CheckedListBox checkedListBoxTask;
    }
}

