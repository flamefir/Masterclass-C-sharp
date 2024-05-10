namespace Cookie_Cookbook
{
    /*
    This exercise creates an cookie cookbook application.
    The design pattern used -> builder
    The builder pattern:
        - Constructs complext objects of different types.
        - Multiple representations can be created, of the complex object.

    The software design:
        Recipe builder class -> build recipes based on the input from the user.
        Recipe Director class -> Oversees the construction of the recipe.
        Concrete Builder class -> Implements different representations of the object.
     */

    public class Program
    {
        static void Main(string[] args)
        {
            var cookBook = new CookBook("Cookie Cookbook");

            // Load predefined recipes
            Console.WriteLine(cookBook);
            Console.WriteLine("Create a new cookie recipe! Available ingredients are:");

            // Print available ingredients

            // User chooses ingredients

            // Exit
        }

    }
}
