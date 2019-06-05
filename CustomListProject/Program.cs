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
            CustomList<int> genericIntComparer = new CustomList<int>();
            bool result = genericIntComparer.Compare(5, 5);

            CustomList<string> genericStringComparer = new CustomList<string>();
            bool bestTeamEver = genericStringComparer.Compare("packers", "packers");

            CustomList<double> genericDoubleComparer = new CustomList<double>();
            bool doubleComparer = genericDoubleComparer.Compare(4, 4);

        }
    }
}
