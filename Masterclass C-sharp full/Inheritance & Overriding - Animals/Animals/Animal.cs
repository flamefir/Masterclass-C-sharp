using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance___Overriding___Animals.Animals
{
    public class Animal
    {
        public virtual int NumberOfLegs { get; } = 0;
    }

    public class Lion : Animal
    {
        public override int NumberOfLegs { get; } = 4;
    }

    public class Tiger : Animal
    {
        public override int NumberOfLegs { get; } = 4;
    }

    public class Duck : Animal
    {
        public override int NumberOfLegs { get; } = 2;
    }

    public class Spider : Animal
    {
        public override int NumberOfLegs { get; } = 8;
    }
}
