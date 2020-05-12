using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Ball_Game
{
    class Direction
    {
        public int dx { set;  get; }
        public int dy { set;  get; }
        public int speed { set;  get; }

        public Direction()
        {
            this.dx = 0;
            this.dy = 0;
            this.speed = 0;
        }
        public Direction(int dx, int dy, int speed)
        {
            this.dx = dx;
            this.dy = dy;
            this.speed = speed;
        }

        public override string ToString()
        {
            return "dx = [" + this.dx + "], dy = [" + this.dy + "], speed = [" + this.speed + "]";
        }
    }
}
