using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class rectangle
    {
        public int h {  get; set; }
        public int w { get; set; }

        public rectangle() {
            h = 0;
            w = 0;
        }
        public rectangle(int h, int w)
        {
            this.h = h;
            this.w = w;
        }
        public rectangle(int v)
        {
            this.h = v;
            this.w = v;
        }
    }
}
