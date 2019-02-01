using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    class Snake
    {
        public List<char> Body { get; set; }

        public char Symbol { get; set; }
        
        public List<int> BodyCoordinatesX { get; set; }

        public List<int> BodyCoordinatesY { get; set; }

        public Snake()
        {
            this.Body = new List<char>();
            this.BodyCoordinatesX = new List<int>();
            this.BodyCoordinatesY = new List<int>();
        }
    }
}
