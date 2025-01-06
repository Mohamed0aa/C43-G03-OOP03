using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class typeA
    {
        public int a {  get; set; }
        public typeA(int a) 
        {
            this.a = a;
        }

        public void myfun1( )
        {
            Console.WriteLine("im parent");
        }

        public virtual void myfun2()
        {
            Console.WriteLine($"typeA ={a}");

        }
    }
    class typeB:typeA
    {
        public int b { get; set; }
        public typeB(int b,int a) :base(a)
        {
            this.b = b;
        }
        //applying  override using new
        public new void myfun1()//STATIC METHOD
        {
            Console.WriteLine("im child");
        }

        //applying  override using override key :must be non private and virtual
        public override void myfun2() ///DAYNAMIC METHOD
        {
            Console.WriteLine($"typeB={b}");
        }
    }

}
