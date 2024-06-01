﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApp.Students
{
    internal class Student
    {

        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public override string ToString()
        {
            return $"{Id}, {Firstname},{Lastname}";
        }

    }
}
