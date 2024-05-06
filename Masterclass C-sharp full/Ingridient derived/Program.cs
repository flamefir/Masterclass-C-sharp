namespace Ingridient_derived
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ingredients = new List<Ingredient>
            {
                new Cheddar(),
                new Mozzarella(),
                new Pepperoni(),
            };

            foreach (var ingredient in ingredients)
            {
                Console.WriteLine(ingredient.Name);
            }

            //Console.WriteLine(chesse.PublicMethod());
            //Console.WriteLine(chesse.ProtectedMethod());
            //Console.WriteLine(chesse.PrivateMethod());
        }
    }

// Public methods of a class can be used in the base class and derived classes.
// Private methods of a class can not be used in the derived class, or outside.
// Protected members of a class can be used in the derived classes, but cant be used outside.

// Virtual members may be overriden by the inheriting types.

    public class Ingredient
    {
        public virtual string Name { get; set; } = "Some ingredient";

        public string PublicMethod() => "This is public method.";
        protected string ProtectedMethod() => "This is protected method.";
        private string PrivateMethod() => "This is private method.";
    }

    public class Mozzarella : Ingredient
    {
        public override string Name { get; set; } = "Mozzarella";

        public void UseBaseClassMethods()
        {
            Console.WriteLine(PublicMethod());
            Console.WriteLine(ProtectedMethod());
            //Console.WriteLine(PrivateMethod());
        }
    }

    public class Pepperoni : Ingredient
    {
        public override string Name { get; set; } = "Pepperoni";

        public void UseBaseClassMethods()
        {
            Console.WriteLine(PublicMethod());
            Console.WriteLine(ProtectedMethod());
            //Console.WriteLine(PrivateMethod());
        }
    }

    public class Cheddar : Ingredient
    {
        public string Name { get; set; } = "Cheddar";

        public void UseBaseClassMethods()
        {
            Console.WriteLine(PublicMethod());
            Console.WriteLine(ProtectedMethod());
            //Console.WriteLine(PrivateMethod());
        }
    }
}
