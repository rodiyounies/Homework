using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Ball_Game
{
    class Direction
    {
        private int dx { get; }
        private int dy { get; }

        public Direction()
        {
            this.dx = 0;
            this.dy = 0;
        }
        public Direction(int dx, int dy)
        {
            this.dx = dx;
            this.dy = dy;
        }

        public override string ToString()
        {
            return "dx = [" + this.dx + "], dy = [" + this.dy + "]";
        }
    }
}
