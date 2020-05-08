using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Ball_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number of Regular Balls: ");
            int regularBallsCount = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of Monster Balls: ");
            int monsterBallsCount = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of Repellent Balls: ");
            int repellentBallsCount = int.Parse(Console.ReadLine());

            Console.Write("Enter Canvas Width: ");
            int canvasWidth = int.Parse(Console.ReadLine());

            Console.Write("Enter Canvas Height: ");
            int canvasHeight = int.Parse(Console.ReadLine());
            Canvas canvas = new Canvas(canvasWidth, canvasHeight);

            Initializer initializer = new Initializer(regularBallsCount, monsterBallsCount, repellentBallsCount, canvas);
            List<Ball> balls = initializer.init();
            foreach(Ball ball in balls) {
                Console.WriteLine(ball);
            }


            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
