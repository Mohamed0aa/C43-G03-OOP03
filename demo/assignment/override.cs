using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class typeA
    {
        public virtual void myfun1()
        {
            Console.WriteLine("massege from parent");
        }

        
    }
    class typeB : typeA
    {
        //applying  override using new
        public new void myfun1()//STATIC METHOD
        {
            Console.WriteLine("im child");
        }
    }
    class typec : typeA
    {
        //applying  override using new
        public override void myfun1()//STATIC METHOD
        {
            Console.WriteLine("im child");
        }
    }

}