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
            Console.WriteLine(result);

             result = sum(1,2,3);
            Console.WriteLine(result);
            #endregion
        }
    }
}
