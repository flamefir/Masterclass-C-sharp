namespace DiceRollGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dice = new Dice(6);
            var game = new GameLogic(dice.Roll());
            Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");
            do
            {
                game.Entry(Console.ReadLine()!);
            } while (!game.ExitFlag);
            Console.Read();
        }
    }
}
