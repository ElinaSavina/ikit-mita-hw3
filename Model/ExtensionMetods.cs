﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class ExtensionMetods
    {
        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }
    }
}
