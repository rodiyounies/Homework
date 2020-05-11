using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Ball_Game
{
    class BallsRenderer
    {
        private List<Ball> balls;
        private Canvas canvas;

        public BallsRenderer(List<Ball> balls, Canvas canvas)
        {
            this.balls = balls;
            this.canvas = canvas;
        }

        public void render()
        {
            while (isDone() == true)
            {
                foreach (Ball ball in balls)
                {
                    ball.move(canvas);
                    handleCollisions(ball);
                }
            }
        }

        private void handleCollisions(Ball movingBall)
        {
            foreach (Ball ball in balls)
            {
                if(movingBall.id.Equals(ball.id))
                {
                    continue;
                }


            }
        }

        private bool isDone()
        {
            bool isDone = true;
            foreach (Ball ball in balls)
            {
                if(ball.isDone == false)
                {
                    return false;
                }
            }

            return isDone;
        }
    }
}
