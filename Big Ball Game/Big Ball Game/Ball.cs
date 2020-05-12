﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Ball_Game
{
    abstract class Ball
    {
        public enum BallType
        {
            UNKNOWN,
            REGULAR_BALL,
            MONSTER_BALL,
            REPELLENT_BALL
        }

        public string id { get; }
        public BallType ballType { get; set; }
        public float radius { get; set; }
        public Position position { set; get; }
        public Color color { set;  get; }
        public Direction direction { get; }
        public bool isDone { set;  get; }

        public Ball(float radius, Position position, Color color, Direction direction)
        {
            this.radius = radius;
            this.position = position;
            this.color = color;
            this.direction = direction;

            id = System.Guid.NewGuid().ToString();
            isDone = false;
            ballType = BallType.UNKNOWN;
        }

        abstract public void move(Canvas canvas);

        virtual public BallType getType() { return BallType.UNKNOWN;  }

        virtual public void swallow(Ball ball) { }
        
    }
}
