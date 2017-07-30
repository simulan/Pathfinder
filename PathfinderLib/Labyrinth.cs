using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderLib
{
    public class Labyrinth
    {
        public Labyrinth(int w,int h,int[] values) {
            this.w = w;
            this.h = h;
            this.values = values;
        }
        public int w { get; set; }
        public int h { get; set; }
        public int[] values { get; set; }
    }
}
