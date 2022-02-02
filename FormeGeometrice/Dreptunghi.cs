﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormeGeometrice
{
    public class Dreptunghi
    {
        public Dreptunghi(Punct A, Punct B, Punct C, Punct D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
        }
            public Dreptunghi(Punct A, Punct C)
        {
            this.A = A;
            this.C = C;
            B.x = C.x;
            B.y = A.y;
            D.x = A.x;
            D.y = C.y;
        }
        public Punct A { get; set; } = new Punct(0, 0);
        public Punct B { get; set; } = new Punct(0, 0);
        public Punct C { get; set; } = new Punct(0, 0);
        public Punct D { get; set; } = new Punct(0, 0);
    }
}
