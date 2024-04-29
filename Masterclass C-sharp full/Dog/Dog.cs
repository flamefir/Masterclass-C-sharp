using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    public class Dog
    {
        string Name;
        string Breed;
        int Weight;

        public Dog(string name, int weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public Dog(string name, string breed, int weight)
        {
            this.Name = name;
            this.Breed = breed;
            this.Weight = weight;
        }

        public string Describe()
        {
            return $"This dog is named {Name}, it's a {Breed}, and it weighs {Weight} kilograms, so it's a {EvaluateSizeOfDog(Weight)} dog.";
        }

        private string EvaluateSizeOfDog(int weight)
        {
            if (weight < 5) { return "tiny"; }
            else if (weight >= 5 && weight < 30) { return "medium"; }
            else { return "large"; }
        }
    }
}
