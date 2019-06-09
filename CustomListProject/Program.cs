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


            List<int> one = new List<int>() { 1, 3, 5 };
            //CustomList<int> one = new CustomList<int>();
            //one.Add(1);
            //one.Add(3);
            //one.Add(5);
            List<int> two = new List<int>() { 2, 4, 6 };

            //CustomList<int> two = new CustomList<int>();
            //two.Add(2);
            //two.Add(4);
            //two.Add(6);

            List<int> result = new List<int>();
            result = one + two;

            CustomList<int> test = new CustomList<int>();

            test.Add(1);







            //CustomList<int> genericIntComparer = new CustomList<int>();
            //bool result = genericIntComparer.Compare(5, 5);

            //CustomList<string> genericStringComparer = new CustomList<string>();
            //bool bestTeamEver = genericStringComparer.Compare("packers", "packers");

            //CustomList<double> genericDoubleComparer = new CustomList<double>();
            //bool doubleComparer = genericDoubleComparer.Compare(4, 4);

        }
    }
}
