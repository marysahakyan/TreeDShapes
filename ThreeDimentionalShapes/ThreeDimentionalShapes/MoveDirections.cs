﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeDimentionalShapes
{
    public struct MoveDirections
    { public float alpha { get; set; }
       public  float betta { get; set; }
       public  float gamma { get; set; }
        public MoveDirections(float a,float b,float c)
        {
            alpha = a;
            betta = b;
            gamma=c;
        }
    }
}
