using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Ball_Game
{
    class Initializer
    {
        public List<Ball> balls { set; get; }
        public int regularBallsCount { set; get; }
        public int monsterBallsCount { set; get; }
        public int repellentBallsCount { set; get; }
        public Canvas canvas { set; get; }
        
        private Random rnd = new Random();

        public Initializer()
        {
            this.regularBallsCount = 0;
            this.monsterBallsCount = 0;
            this.repellentBallsCount = 0;
            this.canvas = null;
            this.balls = new List<Ball>();
        }

        public Initializer(int regularBallsCount, int monsterBallsCount, int repellentBallsCount, Canvas canvas)
        {
            this.regularBallsCount = regularBallsCount;
            this.monsterBallsCount = monsterBallsCount;
            this.repellentBallsCount = repellentBallsCount;
            this.canvas = canvas;
            this.balls = new List<Ball>();
        }

        public List<Ball> init()
        {
            initRegularBalls();
            initMonsterBalls();
            initRepellentBalls();

            return this.balls;
        }

        private void initRepellentBalls()
        {
            for(int i = 0; i < repellentBallsCount; i++)
            {
                int radius = rnd.Next(1, 10);
                Position position = new Position(rnd.Next(canvas.width), rnd.Next(canvas.height));
                Color color = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
                Direction direction = new Direction(rnd.Next(1, 5), rnd.Next(1, 5), rnd.Next(1, 10));

                RepellentBall ball = new RepellentBall(radius, position, color, direction);

                balls.Add(ball);
            }
        }

        private void initMonsterBalls()
        {
            for (int i = 0; i < monsterBallsCount; i++)
            {
                int radius = rnd.Next(1, 10);
                Position position = new Position(rnd.Next(canvas.width), rnd.Next(canvas.height));
                Color color = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
                Direction direction = new Direction(0, 0, rnd.Next(1, 10));

                MonsterBall ball = new MonsterBall(radius, position, color, direction);

                balls.Add(ball);
            }
        }

        private void initRegularBalls()
        {
            for (int i = 0; i < regularBallsCount; i++)
            {
                int radius = rnd.Next(1, 10);
                Position position = new Position(rnd.Next(canvas.width), rnd.Next(canvas.height));
                Color color = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
                Direction direction = new Direction(rnd.Next(1, 5), rnd.Next(1, 5), rnd.Next(1, 10));

                RegularBall ball = new RegularBall(radius, position, color, direction);

                balls.Add(ball);
            }
        }
    }
}
