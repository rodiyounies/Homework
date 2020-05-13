using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Ball_Game
{
    class CircleCrossingsDetectionStrategy
    {
        /*
         * Let d = the distance between the circles’ centers so . 
         * Solving for a gives .Now there are three cases: 
         * 
         * If d > r0 + r1: The circles are too far apart to intersect.
         * If d < |r0 – r1|: One circle is inside the other so there is no intersection. 
         * If d = 0 and r0 = r1: The circles are the same. 
         * If d = r0 + r1: The circles touch at a single point. 
         * Otherwise: The circles touch at two points.
         * 
         * Ref: http://csharphelper.com/blog/2014/09/determine-where-two-circles-intersect-in-c/
         * */
        public bool areCrossing(Ball a, Ball b)
        {
            bool areBallsFarCrossing = false;

            int x1 = a.position.x;
            int y1 = a.position.y;

            int x2 = b.position.x;            
            int y2 = b.position.y;

            double totalRadius = a.radius + b.radius;
            double d = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2));
            if(d <= totalRadius)
            {
                areBallsFarCrossing = true;
                Console.WriteLine("Collission between {0}[{1}] & {2}[{3}]", a.ballType, a.id, b.ballType, b.id);
            }
            
            return areBallsFarCrossing;
        }
    }
}
