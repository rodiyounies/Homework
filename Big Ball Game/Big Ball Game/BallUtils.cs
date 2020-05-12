using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Ball_Game
{
    class BallUtils
    {
        public static Color combineColors(Ball eater, Ball eaten)
        {
            int r = Convert.ToInt32(((Convert.ToInt32(eater.color.R) * Convert.ToInt32(eater.radius)) + 
                                    (Convert.ToInt32(eaten.color.R) * Convert.ToInt32(eaten.radius))) / 
                                    (eater.radius + eaten.radius));
            if(r > 255)
            {
                r = 255;
            }

            int g = Convert.ToInt32(((Convert.ToInt32(eater.color.G) * Convert.ToInt32(eater.radius)) +
                                    (Convert.ToInt32(eaten.color.G) * Convert.ToInt32(eaten.radius))) /
                                    (eater.radius + eaten.radius));
            if (g > 255)
            {
                g = 255;
            }


            int b = Convert.ToInt32(((Convert.ToInt32(eater.color.B) * Convert.ToInt32(eater.radius)) +
                                    (Convert.ToInt32(eaten.color.B) * Convert.ToInt32(eaten.radius))) /
                                    (eater.radius + eaten.radius));
            if (b > 255)
            {
                b = 255;
            }

            return Color.FromArgb(r, g, b);
        }
    }
}
