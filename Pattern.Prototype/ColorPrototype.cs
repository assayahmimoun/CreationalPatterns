﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Prototype
{
    public abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }
}