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

        public static complex operator +(complex x, complex y)
        {
            return new complex
            {
                real = (x?.real??0) + (y?.real ?? 0),
                imag= (x?.imag ?? 0) + (y?.imag ?? 0)

            };
        }
        #endregion

        public override string ToString()
        {
            return $"{real}+{imag}i";
        }
    }
}
