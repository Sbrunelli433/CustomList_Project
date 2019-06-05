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
            get
            {
                if (count > 4)
                {
                    throw new IndexOutOfRangeException();
                }
                return testList[i];
            }
            set
            {
                if (count > 4)
                {
                    throw new IndexOutOfRangeException();
                }
                testList[i] = value;
            }
        }
        private int count;
        public int Count
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
