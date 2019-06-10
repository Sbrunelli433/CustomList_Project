using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable
    {
        //member variables
        private T[] testArray;
        private int count;
        private int capacity;

        public T this[int i]
        {
            get
            {
                if (i < count && i >= 0 )
                {
                    return testArray[i];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }

            }
            set
            {
                if (i <= count && i >=0 )
                {
                    testArray[i] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        //properties
        public int Count
        {
            get { return count; }
        }

        public int Capacity
        {
            get { return capacity; }
        }
        //Constructor
        public CustomList()
        {
            count = 0;
            capacity = 6;
            testArray = new T[capacity];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return testArray[i];
            }
        }
        //methods
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
            }
            return result;
        }


        //zip method operator overload
        public static CustomList<T> OperatorZip(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> result = new CustomList<T>();
            if (list1.count == list2.count)
            {
                for (int i = 0; i < list1.count; i++)
                {
                    //use this to get result = 1 2 3 4 5 6; 
                    result.Add(list1[i]);
                    result.Add(list2[i]);
                }
            }

            if (list1.count > list2.count)
            {
                //use the count of list two to zip together
                for (int i = 0; i < list1.count; i++)
                {
                    result.Add(list1[i]);
                    if (i < list2.Count)
                    {
                        result.Add(list2[i]);
                    }
                }
            }
            if (list1.count < list2.count)
            {
                //use the count of list two to zip together
                for (int i = 0; i < list2.count; i++)
                {
                    if (i < list1.Count)
                    {
                        result.Add(list1[i]);
                    }
                    result.Add(list2[i]);
                }
            }
            return result;
        }
    }
}

