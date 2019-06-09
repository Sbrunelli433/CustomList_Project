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
        private T[] listC;
        //public T this[int j]
        //{
        //    get
        //    {
        //        if (count > capacityC)
        //        {
        //            throw new IndexOutOfRangeException();
        //        }
        //        return listC[j];
        //    }
        //    set
        //    {
        //        if (count > capacityC)
        //        {
        //            throw new IndexOutOfRangeException();
        //        }
        //        listC[j] = value;
        //    }
        //}
        private int capacityC;
        public int CapacityC
        {
            get { return capacityC; }
        }

        public CustomList()
        {
            count = 0;
            capacity = 4;
            //capacityC = 6;
            testArray = new T[capacity];
            //listC = new T[capacityC];

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
                testArray = biggerArray;
            }
            else
            {
                testArray[count] = item;
            }
            count++;
        }

        public void Remove(T item)
        {
            T[] smallerArray = new T[capacity];
            int j = 0;
            for (int i = 0; i < count; i++, j++)
            {
                if (testArray[i].Equals(item))
                {
                    smallerArray[j] = testArray[i + 1];
                    j--;
                }
                else
                {
                    smallerArray[j] = testArray[i];
                }
            }
            testArray = smallerArray;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {

                stringBuilder.Append(testArray[i] + " ");
            }
            return stringBuilder.ToString();
        }


        public static CustomList<T> operator + (CustomList<T> one, CustomList<T>two)
        {
            CustomList<T> result = new CustomList<T>();
            result = one + two;
            return result;
        }
         


    }






    }

