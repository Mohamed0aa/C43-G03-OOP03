using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class employee
    {

        public virtual void work ()
        {
            Console.WriteLine("Employee is working");
        }
    }
    class manager : employee
    {
        public override void work()
        {
            Console.WriteLine("Manager is managing");
        }
    }

}
