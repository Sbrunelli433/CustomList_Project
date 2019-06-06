using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        private T[] testArray;
        public T this[int i]
        {
            get
            {
                if (count > capacity)
                {
                    capacity = capacity * 2;
                    throw new IndexOutOfRangeException();
                }
                return testArray[i];
            }
            set
            {
                if (count > capacity)
                {
                    throw new IndexOutOfRangeException();
                }
                testArray[i] = value;
            }
        }

        private int count;
        public int Count
        {
            get { return count; }
        }
 
        private int capacity;
        public int Capacity
        {
            get { return capacity; }
        }

        public CustomList()
        {
            count = 0;
            capacity = 4;
            testArray = new T[capacity];
            
        }

        public void Add(T item)
        {
            // if we are about to run out of room
            // make more!
            if (count>=capacity)
            {
                capacity = capacity * 2;
                T[] biggerArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    biggerArray[i] = testArray[i];
                }
                biggerArray[count] = item;
                count++;
                testArray = biggerArray;
            }
            else
            {
                testArray[count] = item;
                count++;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public void Remove(T item)
        {
            //if (count>capacity)
            //{
            //    for (int i = 0; i < count; i--)
            //    {
            //        testArray[item];
            //    }
            //}

        }

        //public void Insert(int index, T item)
        //{

        //}





    }


}
