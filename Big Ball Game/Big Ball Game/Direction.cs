using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Ball_Game
{
    class Direction
    {
        private float speed;
        private int dx;
        private int dy;

        public Direction(float speed, int dx, int dy)
        {
            this.speed = speed;
            this.dx = dx;
            this.dy = dy;
        }

    }
}
