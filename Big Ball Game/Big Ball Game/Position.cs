using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Ball_Game
{
    class Position
    {
        public int x { set;  get; }
        public int y { set;  get; }
    
        
        public Position()
        {
            this.x = 0;
            this.y = 0;
        }
        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "x = [" + this.x + "], y = [" + this.y + "]";
        }
    }
}
