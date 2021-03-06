﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components
{
    public static class StringEnumerableExtension
    {
        public static string Join(this IEnumerable<string> source, string delimiter)
        {
            return source.Aggregate((x, y) => x + delimiter + y); 
        }

        public static string Join(this IEnumerable<string> source)
        {
            return source.Join("");
        }

        public static string JoinLines(this IEnumerable<string> source)
        {
            return source.Join("\r\n");
        }
    }
}
