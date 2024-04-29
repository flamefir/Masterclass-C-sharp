using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {
        private int Base;
        private int Height;

        public Triangle(int @base, int height)
        {
            Base = @base;
            Height = height;
        }

        public int CalculateArea()
        {
            return (@Base * Height) / 2;
        }

        public string AsString()
        {
            return $"Base is {Base}, height is {Height}";
        }
    }
}
