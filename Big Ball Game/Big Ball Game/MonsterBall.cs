﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Ball_Game
{
    class MonsterBall : Ball
    {
        public MonsterBall(float radius, Position position, Color color, Direction direction)
            : base(radius, position, color, direction)
        {

        }

        public override string ToString()
        {
            return "Monster Ball: radius = [" + base.radius + "], Position = [ " + base.position + "]," +
                ", Color = [" + base.color + "]," + "Direction = [" + direction + "]";
        }
    }
}
