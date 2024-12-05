﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSHAMBO_LAB
{
    internal abstract class Player
    {
        public string Name { get; set; }
        public Roshambo Value { get; set; }
        public abstract Roshambo GenerateRoshambo();
    }
}
