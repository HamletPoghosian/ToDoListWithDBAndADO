using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Lib
{
    public class MyTask
    {
        #region Private fields
        private string mywork;
        private bool isdone;
        private int id;
        #endregion

        #region CtorMyTaskClass
        public MyTask()
        {

        }
        public MyTask(string s, bool b = false)
        {
            Mywork = s;
            Isdone = b;

        }
        #endregion

        #region PropertyMyTaskClass
        public string Mywork
        {
            get => mywork;
            set => mywork = value;
        }
        public bool Isdone
        {
            get => isdone;
            set => isdone = value;
        }
        public int Id { get => id; set => id = value; }
        #endregion

        public override string ToString()
        {
            return Id+"\t"+Mywork + "\t" + Isdone;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
