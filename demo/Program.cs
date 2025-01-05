using System.Security.Cryptography;

namespace demo
{
    internal class Program
    {
        static int sum(int a,int b)
        {
            return a + b;
        }
        static double sum(double a, int b)
        {
            return a + b;
        }
        static int sum(int a, int b,int c)
        {
            return a + b+c;
        }
        static void Main(string[] args)
        {
            #region vedio 1 
              //over loading using same function with diffrent task and [type of paramter and order]
            dynamic result =sum(1,2);
            //Console.WriteLine(result);

             result = sum(1,2,3);
            //Console.WriteLine(result);
            #endregion

            #region vedio 2 binary operator
            //complex c1 =new complex() { real = 1, imag = 2 };
            //complex c2 = new complex() { real = 1, imag = 2 };
            //complex c3;
            //c3 = c1 + c2;
            //Console.WriteLine(c3);
            #endregion
            #region vedio 3 unary operator
            //complex c1 = new complex() { real = 1, imag = 2 };
            //c1++;
            //Console.WriteLine(c1);
            #endregion

            #region vedio 4 comparsion operator
            //complex c1 = new complex() { real = 5, imag = 3 };
            //complex c2 = new complex() { real = 1, imag = 2 };
            //if (c1 > c2) Console.WriteLine("c1is biggest");
            //else if (c1 < c2) Console.WriteLine("c2is least");
            //else Console.WriteLine("equale");
            #endregion

            #region vedio 5 casting operator overloading
            complex c1 = new complex()
            {
                real = 1, imag = 2
            };
            int n = (int)c1;
            Console.WriteLine(n);
            #endregion





        }
    }
}
