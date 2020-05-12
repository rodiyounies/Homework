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

        public override BallType getType()
        {
            return BallType.REGULAR_BALL;
        }

        /*
         *  1. Regular ball with regular ball - the larger ball swallows the 
smaller one, the small ball disappears from the system, the 
large ball radius increases with the small ball radius, 
the color of the large ball changes by combining the colors of 
the two balls in proportion to their size (combination  colors are 
done separately on each RGB component).
         */
        public void swallow(RegularBall ball)
        {
            RegularBall eater, eaten;
            if(this.radius > ball.radius)
            {
                eater = this;
                eaten = ball;
            } else
            {
                eater = ball;
                eaten = this;
            }

            eaten.isDone = true;
            eater.color = BallUtils.combineColors(eater, eaten);
            eater.radius += eaten.radius;
        }

        public void swallow(MonsterBall ball)
        {
            this.isDone = true;
            ball.color = BallUtils.combineColors(ball, this);
            ball.radius += this.radius;

        }

        public void swallow(RepellentBall ball)
        {
            ball.color = BallUtils.combineColors(ball, this);
            this.direction.dx *= -1;
            this.direction.dy *= -1;
        }
    }
}
