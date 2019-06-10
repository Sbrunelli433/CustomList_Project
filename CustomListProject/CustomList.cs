using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable
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
        private int one;
        public int One
        {
            get { return one; }
            set { one = value; }
        }

        private int two;
        public int Two
        {
            get { return two; }
            set { two = value; }
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
            capacity = 6;
            testArray = new T[capacity];
        }

        public void Add(T item)
        {
            // if we are about to run out of room
            // make more!
            if (count >= capacity)
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
            bool haveRemovedItem = false;
            for (int i = 0; i < count; i++, j++)
            {
                if (testArray[i].Equals(item))
                {
                    smallerArray[j] = testArray[i + 1];
                    j--;
                    haveRemovedItem = true;
                }
                else
                {
                    smallerArray[j] = testArray[i];
                }
            }
            testArray = smallerArray;
            if (haveRemovedItem)
            {
                count--;
            }
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

        public static CustomList<T> operator + (CustomList<T> one, CustomList<T> two)
        {
            CustomList<T> result = new CustomList<T>();

            for (int i = 0; i < one.count; i++)
            {
                result.Add(one[i]);
            }

            for (int i = 0; i < two.count; i++)
            {
                result.Add(two[i]);
            }
            return result;
        }

        public static CustomList<T> operator - (CustomList<T> one, CustomList<T> two)
        {
            CustomList<T> result = new CustomList<T>();


            for (int i = 0; i < one.count; i++)
            {
                    result.Add(one[i]);
            }

            for (int i = 0; i < result.count; i++)
            {
                for (int j = 0; j < two.count; j++)
                {
                    result.Remove(two[j]);
                }
                //if (two[i].Equals(one[i]))
                //{
                //    result.Remove(one[i]);
                //}
            }
            return result;
        }


        //zip method operator overload
        public static CustomList<T> operatorZip(CustomList<T> one, CustomList<T> two)
        {
            CustomList<T> result = new CustomList<T>();
            if (one.count < two.count)
            {
                //use the count of list two to zip together
                for (int i = 0; i < two.count; i++)
                {
                    // only do this if 'i' is a valid index for list "one"
                    result.Add(one[i]);

                    result.Add(two[i]);
                }
            }
            else
            {
                for (int i = 0; i < one.count; i++)
                {
                    result.Add(one[i]);

                    // only do this if 'i' is a valid index for list "two"
                    if (one.count < two.count)
                    {
                        result.Add(two[i]);
                    }

                }
            }
 
            return result;

        }

        public void GetEnumerator()
        {

            throw new NotImplementedException();
        }



        //public IEnumerable GetEnumerator()
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        yield return one[i];
        //    }

        //    throw new NotImplementedException();
        //}
    }






}

