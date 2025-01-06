using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class complex
    {
        public int real {  get; set; }
        public int imag { get; set; }

        #region operator over loading

        #region binary
        public static complex operator +(complex x, complex y)
        {
            return new complex
            {
                real = (x?.real ?? 0) + (y?.real ?? 0),
                imag = (x?.imag ?? 0) + (y?.imag ?? 0)

            };
        } 
        #endregion

        #region unary
        public static complex operator ++(complex x)
        {
            return new complex
            {
                real = (x?.real ?? 0) + 1,
                imag = (x?.imag ?? 0)

            };
        } 
        #endregion

        #region comparsion
        public static bool operator >(complex x, complex y)
        {
            if (x?.real == y?.real)
            {
                return x?.imag > y?.imag;
            }
            else
                return x?.real > y?.real;
        }
        public static bool operator <(complex x, complex y)
        {
            if (x?.real == y?.real)
            {
                return x?.imag < y?.imag;
            }
            else
                return x?.real < y?.real;
        }

        #endregion

        #endregion

        #region casting overloading
        //explicit casting
        public static explicit operator int (complex x)
        {
            return (x?.real ?? 0);
        }

        public static explicit operator string(complex x)
        {
            return (x?.real.ToString() ?? "");
        }
        #endregion
        public override string ToString()
        {
            return $"{real}+{imag}i";
        }


    }
}
