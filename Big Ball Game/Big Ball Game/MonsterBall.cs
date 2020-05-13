using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Ball_Game
{
    class MonsterBall : Ball
    {
        public MonsterBall(int radius, Position position, Color color, Direction direction)
            : base(radius, position, color, direction)
        {
            ballType = BallType.MONSTER_BALL;
        }

        public override string ToString()
        {
            return "Monster Ball: id = [" + base.id + "], radius = [" + base.radius + "], Position = [ " + base.position + "]," +
                ", Color = [" + base.color + "]," + "Direction = [" + direction + "]";
        }
        public override void move(Canvas canvas)
        {

        }

        public override BallType getType()
        {
            return BallType.MONSTER_BALL;
        }

        public override void swallow(Ball ball)
        {
            if (ball.GetType() == typeof(RegularBall))
            {
                swallow((RegularBall)ball);
            }
            else if (ball.GetType() == typeof(RepellentBall))
            {
                swallow((RepellentBall)ball);
            }
        }

        public void swallow(RegularBall ball)
        {
            ball.isDone = true;
            Console.WriteLine("Terminated " + ball.ballType + " Ball [ " + ball.id + "]");
            this.color = BallUtils.combineColors(this, ball);
            this.radius += ball.radius;
        }

        public void swallow(RepellentBall ball)
        {
            ball.radius = ball.radius / 2;
        }
    }
}
