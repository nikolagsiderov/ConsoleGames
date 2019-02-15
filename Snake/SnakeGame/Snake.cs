using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    class Snake
    {
        public Queue<char> Body { get; set; }

        public Queue<int> BodyCoordinatesX { get; set; }

        public Queue<int> BodyCoordinatesY { get; set; }

        public char Symbol { get; set; }

        public Snake()
        {
            this.Body = new Queue<char>();
            this.BodyCoordinates = new Queue<int>();
        }
    }
}
