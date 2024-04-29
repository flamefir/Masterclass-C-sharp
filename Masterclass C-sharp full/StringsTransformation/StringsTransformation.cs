﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsTransformation
{
    public static class StringsTransformator
    {
        public static string TransformSeparators(string input, string originalSeparator, string targetSeparator)
        {
            string[] transform = input.Split(originalSeparator);
            return string.Join(input, targetSeparator);
        }
    }
}
