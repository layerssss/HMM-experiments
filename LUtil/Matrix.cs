using System;
using System.Collections.Generic;
using System.Text;

namespace LUtil
{
    public class Matrix<T>
    {
        public static T[][] GetNew(int rows,int cols)
        {
            T[][] a =new T[rows][];
            for (int i = 0; i < rows; i++)
            {
                a[i] = new T[cols];
            }
            return a;
        }

    }
}
