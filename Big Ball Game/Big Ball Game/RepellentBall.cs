using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Ball_Game
{
    class RepellentBall : Ball
    {
        public RepellentBall(int radius, Position position, Color color, Direction direction)
            : base(radius, position, color, direction)
        {
            ballType = BallType.REPELLENT_BALL;
        }

        public override string ToString()
        {
            return "Repellent Ball: id = [" + base.id + "], radius = [" + base.radius + "], Position = [ " + base.position + "]," +
                ", Color = [" + base.color + "]," + "Direction = [" + direction + "]";
        }

        public override void move(Canvas canvas)
        {
            Console.WriteLine("Repellent Ball[{0}] is moving", this.id);
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
;
            this.position.x = this.position.x + (this.direction.dx * this.direction.speed);
            this.position.y = this.position.y + (this.direction.dy * this.direction.speed);
        }

        public override BallType getType()
        {
            return BallType.REPELLENT_BALL;
        }

        public void swallow(RegularBall ball)
        {
            this.color = BallUtils.combineColors(this, ball);
            ball.direction.dx *= -1;
            ball.direction.dy *= -1;
        }

        public override void swallow(Ball ball)
        {
            if (ball.GetType() == typeof(MonsterBall))
            {
                swallow((MonsterBall)ball);
            }
            else if (ball.GetType() == typeof(RepellentBall))
            {
                swallow((RepellentBall)ball);
            }
        }

        public void swallow(MonsterBall ball)
        {
            this.radius = this.radius / 2;
        }

        public void swallow(RepellentBall ball)
        {
            ball.color = BallUtils.combineColors(ball, this);
            this.color = BallUtils.combineColors(this, ball);
        }
    }
}
