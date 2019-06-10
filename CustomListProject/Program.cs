using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomList<int> test = new CustomList<int>();

            //test.Add(1);
            //test.Add(2);
            //test.Add(3);
            //test.Add(4);
            //test.Add(5);
            ////test.Add(6);
            ////test.Add(7);
            ////test.Add(8);
            ////test.Add(9);
            ////test.Remove(3);
            ////test.Remove(0);
            ////test.Remove(2);
            //test.ToString();


            CustomList<int> one = new CustomList<int>();
            one.Add(1);
            one.Add(3);
            one.Add(5);

            CustomList<int> two = new CustomList<int>();
            two.Add(2);
            two.Add(4);
            two.Add(6);
            

            //CustomList<int> two = new CustomList<int>();
            //two.Add(2);
            //two.Add(1);
            //two.Add(6);

            CustomList<int> result = new CustomList<int>();

            //result = one - two;

            //result = one - two;


            CustomList<int> odd = new CustomList<int>();
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            odd.Add(7);

            CustomList<int> even = new CustomList<int>();
            even.Add(2);
            even.Add(4);
            even.Add(6);
            even.Add(8);
            even.Add(10);
            CustomList<int>.OperatorZip(odd, even);



        }
    }
}
