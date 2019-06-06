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
            CustomList<int> test = new CustomList<int>();

            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            test.Add(5);


            //CustomList<int> genericIntComparer = new CustomList<int>();
            //bool result = genericIntComparer.Compare(5, 5);

            //CustomList<string> genericStringComparer = new CustomList<string>();
            //bool bestTeamEver = genericStringComparer.Compare("packers", "packers");

            //CustomList<double> genericDoubleComparer = new CustomList<double>();
            //bool doubleComparer = genericDoubleComparer.Compare(4, 4);

        }
    }
}
