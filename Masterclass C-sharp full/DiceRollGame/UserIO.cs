using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame
{
    public enum ErrorCodes
    {
        WrongInput = 0,
        OutOfBoundary = -1,
        Unknown = -2,
    }

    public class UserIO
    {


        public static int InputToInt(string input)
        {
            if (!int.TryParse(input, out var value) || string.IsNullOrEmpty(input))
            {

                return (int)ErrorCodes.WrongInput;
            }
            else if (value < 1 || value > 6)
            {
                return (int)ErrorCodes.OutOfBoundary;
            }

            return value;
        }

        public static void Output(int outputIndicator, string outputText = "") 
        {
            switch (outputIndicator)
            {
                case (int)ErrorCodes.WrongInput:
                    Console.WriteLine("Incorrect input");
                    break;
                case (int)ErrorCodes.OutOfBoundary:
                    Console.WriteLine("Number written is not between 1 - 6");
                    break;
                default: 
                    Console.WriteLine(outputText);
                    break;
            }
        }
    }
}
