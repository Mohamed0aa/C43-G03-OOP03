﻿using System.Security.Cryptography;

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
            //complex c1 = new complex()
            //{
            //    real = 1, imag = 2
            //};
            //int n = (int)c1;
            //Console.WriteLine(n);
            #endregion

            #region vedio 6 app on casting
            //user mo = new user()
            //{
            //    id = 1,
            //    name = "mohamed ali",
            //    age = 21,
            //    email = "mozli@gmail",
            //    password = "password",
            //};
            //user_model  mo_model= (user_model)mo;
            //Console.WriteLine(mo_model.id);
            //Console.WriteLine(mo_model.first_name);
            //Console.WriteLine(mo_model.last_name);
            //Console.WriteLine(mo_model.age);
            //Console.WriteLine(mo_model.email);
            //Console.WriteLine(mo_model.password);
            #endregion

            #region vedio 7 
            //typeA TP = new typeA(1);
            //TP.a = 11;
            //TP.myfun2();

            #endregion

            #region 8 BINDING

            typeA TP = new typeB(1,2);
            TP.a = 11;
            TP.myfun1();
            
            //static binding :copilar will binding function  call based on refrence not object
            //at compilation time
            TP.myfun2();
            //dynamic binding [late]
            //clr  will bind function call based on object not refrence
            //at run time



            #endregion





        }
    }
}
