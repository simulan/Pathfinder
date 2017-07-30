using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderLib
{
    public class Labyrinth
    {
        public Labyrinth(int w,int h,Cell[] cells) {
            this.Width = w;
            this.Height = h;
            this.Cells = cells;
        }
        public int Width { get; set; }
        public int Height { get; set; }
        public Cell[] Cells { get; set; }
    }
}
