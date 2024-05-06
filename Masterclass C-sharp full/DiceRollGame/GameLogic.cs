using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame
{
    public class GameLogic
    {
        private const int MaxGuess = 3 - 1;

        private int DiceRoll {  get; init; }
        
        public bool ExitFlag = false;

        public static int NumberOfTries = 0;

        public GameLogic(int diceRoll)
        {
            DiceRoll = diceRoll;
        }

        public void Entry(string Guess)
        {
            var numberGuess = UserIO.InputToInt(Guess);

            if (0 >= numberGuess)
            {
                UserIO.Output(numberGuess);
                return;
            }
            else if (DiceRoll != numberGuess && NumberOfTries < MaxGuess)
            {
                UserIO.Output(numberGuess, "Wrong number");
                NumberOfTries++;
                return;
            }
            else if(DiceRoll != numberGuess && NumberOfTries == MaxGuess)
            {
                UserIO.Output(numberGuess, "Wrong number\nYou lose");
                ExitFlag = true;
                return;
            }

            UserIO.Output(numberGuess, "You win!");
            ExitFlag = true;
        }
    }
}
