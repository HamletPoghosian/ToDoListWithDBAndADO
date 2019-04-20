using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Lib
{
    public class MyToDoList : IEnumerable<MyTask>
    {
        private List<MyTask> list = new List<MyTask>();


        public int Count { get => list.Count; }
        public bool MyContains(MyTask ts)
        {
            return list.Contains(ts);

        }
        public void IsComletid(MyTask my)
        {
            my.Isdone = true;
        }
        public void NoComletid(MyTask my)
        {
            my.Isdone = false;
        }
        public void Add(MyTask mytask)
        {
            list.Add(mytask);

        }
        public void Del(MyTask mytask)
        {

            list.Remove(mytask);
        }
        public void AddtoIndex(MyTask mytask, int index)
        {
            if (index > list.Count)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                list.Insert(index, mytask);
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }
        public IEnumerable<MyTask> ShowCompletit(MyToDoList todo)
        {
            return todo.Where(x => x.Isdone == true);
        }
        public IEnumerable<MyTask> ShowNotCompletit(MyToDoList todo)
        {
            return todo.Where(x => x.Isdone == false);
        }
        public IEnumerable<MyTask> ShowAll(MyToDoList todo)
        {
            return todo.Select(x => x);
        }
        IEnumerator<MyTask> IEnumerable<MyTask>.GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
