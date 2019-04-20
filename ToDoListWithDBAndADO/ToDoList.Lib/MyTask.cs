using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Lib
{
    public class MyTask
    {
        private string mywork;
        private bool isdone;


        public MyTask()
        {

        }
        public MyTask(string s, bool b = false)
        {
            Mywork = s;
            Isdone = b;

        }
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


        public override bool Equals(object obj)
        {
            return this.ToString() == ((MyTask)obj).ToString();
        }

        public override string ToString()
        {
            return Mywork + "\t" + Isdone;
        }
    }
}
