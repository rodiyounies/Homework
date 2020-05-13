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
        private CircleCrossingsDetectionStrategy crossingStrategy;

        public BallsRenderer(List<Ball> balls, Canvas canvas)
        {
            this.balls = balls;
            this.canvas = canvas;

            crossingStrategy = new CircleCrossingsDetectionStrategy();
        }

        public void render()
        {
            Console.WriteLine("Render started");
            while (isAllDone() == false)
            {
                foreach (Ball ball in balls)
                {
                    if (ball.isDone == false)
                    {
                        process(ball);
                        System.Threading.Thread.Sleep(1000);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("It is all done!");
        }

        private void process(Ball movingBall)
        {
            //Console.WriteLine("Moving Ball before moving: " + movingBall);
            movingBall.move(canvas);
            //Console.WriteLine("Moving Ball after moving: " + movingBall);

            foreach (Ball ball in balls)
            {
                if (movingBall.id.Equals(ball.id) || 
                    ball.getType() == Ball.BallType.MONSTER_BALL || ball.isDone == true)
                {
                    continue;
                }

                bool crosssingDetected = crossingStrategy.areCrossing(ball, movingBall);
                if (crosssingDetected)
                {
                    movingBall.swallow(ball);
                    //Console.WriteLine("Moving Ball After collision: " + movingBall);
                    //Console.WriteLine("Ball After collision: " + ball);
                }
            }
        }

        private bool isAllDone()
        {
            bool isDone = true;
            foreach (Ball ball in balls)
            {
                if(ball.ballType == Ball.BallType.REGULAR_BALL && ball.isDone == false)
                {
                    return false;
                }
            }

            return isDone;
        }
    }
}
