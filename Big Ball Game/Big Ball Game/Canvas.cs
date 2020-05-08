using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Ball_Game
{
    class Canvas
    {
        public int width { get; set; }
        public int height { get; set; }

        public Canvas()
        {
            this.width = 1000;
            this.height = 1000;
        }

        public Canvas(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public override string ToString()
        {
            return "Canvas: width = [" + this.width + "], height = [" + this.height + "]";
        }
    }
}
