using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Ball_Game
{
    class Ball
    {
        private float radius;
        private Position position;
        private Color color;
        private Direction direction;

        public Ball(float radius, Position position, Color color, Direction direction)
        {
            this.radius = radius;
            this.position = position;
            this.color = color;
            this.direction = direction;
        }
    }
}
