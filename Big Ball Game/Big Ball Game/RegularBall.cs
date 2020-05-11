using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Ball_Game
{
    class RegularBall : Ball
    {
        public RegularBall(float radius, Position position, Color color, Direction direction) 
            : base(radius, position, color, direction)
        {
            ballType = BallType.REGULAR_BALL;
        }

        public override string ToString()
        {
            return "Regular Ball: radius = [" + base.radius + "], Position = [ " + base.position + "]," +
                ", Color = [" + base.color + "]," + "Direction = [" + direction + "]";
        }

        public override void move(Canvas canvas)
        {
            if (isDone == true)
            {
                return;
            }

            if (this.position.x >= canvas.width)
            {
                this.position.x = this.position.x - canvas.width;
            }

            if (this.position.y >= canvas.height)
            {
                this.position.y = this.position.y - canvas.height;
            }

            this.position.x = this.position.x + (this.direction.dx * this.direction.speed);
            this.position.y = this.position.y + (this.direction.dy * this.direction.speed);
        }

        public void swallow(RegularBall ball)
        {
            
        }

        public void swallow(MonsterBall ball)
        {

        }

        public void swallow(RepellentBall ball)
        {

        }
    }
}
