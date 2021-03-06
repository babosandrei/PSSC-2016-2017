﻿using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Professor
{
    //Entity
    public class Professor
    {
        public PlainText Name { get; internal set; }
        public Guid proffesorID { get; internal set; }

        public Professor(Guid ID,PlainText name)
        {
            proffesorID = ID;
            Name = name;
        }
    }
}
