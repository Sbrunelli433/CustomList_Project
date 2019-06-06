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
                if (count > 4)
                {
                    throw new IndexOutOfRangeException();
                }
                return testArray[i];
            }
            set
            {
                if (count > 4)
                {
                    throw new IndexOutOfRangeException();
                }
                testArray[i] = value;
            }
        }
        //compare Count to [i];

        //private T[] pokemonTestList = new T[9](testList);
        //public T pokemonTestList[int i]
        //{
        //    get
        //    {
        //        if (count > 9)
        //        {
        //            throw new IndexOutOfRangeException();
        //        }
        //        return testList[i];
        //    }
        //    set
        //    {
        //        if (count > 9)
        //        {
        //            throw new IndexOutOfRangeException();
        //        }
        //        testList[i] = value;
        //    }
        //}


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

            //testArray[count] = item;
            //count++;
            ////Array.Resize(ref testArray, capacity++);

            //if (count >= capacity)
            //{
            //    T[] biggerArray = new T[capacity++];


            //    testArray = biggerArray;
            //}

        }


        public void Insert(int index, T item)
        {

        }





    }


}
