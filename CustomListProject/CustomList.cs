using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        public bool Compare(T firstValue, T secondValue)
        {
            if (firstValue.Equals(secondValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
