using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame
{
    public class Dice
    {
        private int SidesCount { get; init; }

        public Dice(int sidesCount)
        {
            SidesCount = sidesCount;
        }

        public int Roll()
        {
            return RandomNumberGenerator.GetInt32(1, SidesCount + 1);
        }
    }
}
