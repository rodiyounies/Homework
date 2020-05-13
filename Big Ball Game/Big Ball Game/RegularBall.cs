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
        public RegularBall(int radius, Position position, Color color, Direction direction) 
            : base(radius, position, color, direction)
        {
            ballType = BallType.REGULAR_BALL;
        }

        public override string ToString()
        {
            return "Regular Ball: id = [" + base.id + "], radius = [" + base.radius + "], Position = [ " + base.position + "]," +
                ", Color = [" + base.color + "]," + "Direction = [" + direction + "]";
        }

        public override void move(Canvas canvas)
        {
            Console.WriteLine("Regular Ball[{0}] is moving", this.id);
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

        public override void swallow(Ball ball)
        {
            if(ball.GetType() == typeof(RegularBall))
            {
                swallow((RegularBall)ball);
            } else if (ball.GetType() == typeof(MonsterBall))
            {
                swallow((MonsterBall)ball);
            }
            else if (ball.GetType() == typeof(RepellentBall))
            {
                swallow((RepellentBall)ball);
            }
        }
               
        public void swallow(RegularBall ball)
        {
            //Console.WriteLine("R vs. R");
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
            Console.WriteLine("Terminated " + eaten.ballType + " Ball [ " + eaten.id + "]");
            eater.color = BallUtils.combineColors(eater, eaten);
            eater.radius += eaten.radius;
        }

        public void swallow(MonsterBall ball)
        {
            //Console.WriteLine("R vs. M");
            this.isDone = true;
            Console.WriteLine("Terminated " + this.ballType + " Ball [ " + this.id + "]");
            ball.color = BallUtils.combineColors(ball, this);
            ball.radius += this.radius;

        }

        public void swallow(RepellentBall ball)
        {
            //Console.WriteLine("Reg vs. Rep");
            ball.color = BallUtils.combineColors(ball, this);
            this.direction.dx *= -1;
            this.direction.dy *= -1;
        }
    }
}
