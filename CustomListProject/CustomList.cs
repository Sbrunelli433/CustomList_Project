using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        private T[] testList = new T[4];
        public T this[int i]
        {
            get { return testList[i]; }
            set { testList[i] = value; }
        }
        private T count;
        public T Count
        {
            get { return count; }
        }
        private T capacity;
        public T Capacity
        {
            get { return capacity; }
        }


   


        public void Add(T item)
        {
            
        }






    }


}
