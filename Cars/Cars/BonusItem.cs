﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class BonusItem : IMoveable, IDrawable
    {
        public char Symbol { get; set; }

        public int X { get; set; }

        public int Y { get; set; }
    }
}
