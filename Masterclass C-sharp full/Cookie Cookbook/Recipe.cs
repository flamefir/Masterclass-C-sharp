using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cookie_Cookbook
{
    public class FileFormatAttribute : Attribute
    {
        public string FormatValue { get; protected set; }

        public FileFormatAttribute(string format) 
        {
            FormatValue = format;    
        }
    }

    //extension method
    public static class FileFormatExtension
    {
        public static string? GetStringValue(this Enum value)
        {
            // Get the type
            Type type = value.GetType();

            // Get fieldinfo for this type
            FieldInfo fieldInfo = type.GetField(value.ToString())!;

            // Get the stringvalue attributes
            FileFormatAttribute[]? attribs = fieldInfo.GetCustomAttributes(typeof(FileFormatAttribute), false) as FileFormatAttribute[];

            // Return the first if there was a match.
            return attribs!.Length > 0 ? attribs[0].FormatValue : null;
        }
    }

    public enum FileFormat
    {
        [FileFormat(".json")]
        Json,

        [FileFormat(".¨txt")]
        Txt,
    }

    public class CookBook
    {
        public string? Name { get; set; }
        public List<Recipe>? Recipes { get; set; }

        public CookBook(string? name)
        {
            Name = name;
            Recipes = Database.GetFromDb(FileFormat.Json, Name!);
        }

        public void AddRecipe(Recipe recipe)
        {
            if (!Recipes!.Any(item => item.Name == recipe.Name))
            {
                Recipes?.Add(recipe);
                Console.WriteLine($"{recipe.Name} was added to the Cook Book {Name}");
            }
            else
            {
                Console.WriteLine($"Recipe named {recipe.Name}, already exists in the Cook Book {Name}");
            }
        }

        public void DeleteRecipe(Recipe recipe)
        {
            if (Recipes?.Count > 0)
            {
                Recipes.Remove(recipe);
            }
            else
            {
                Console.WriteLine("No recipes to delete.");
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} - Current Recipes: {Recipes!.Count}\n");
            foreach (Recipe recipe in Recipes)
            {
                sb.Append(Recipes.IndexOf(recipe) + " - Recipe " + Name);
                sb.AppendLine(recipe.ToString());
            }
            return sb.ToString();
        }
    }

    public class Database
    {

        public static List<Recipe>? GetFromDb(FileFormat fileFormat, string dbName)
        {
            switch (fileFormat)
            {
                case FileFormat.Json:
                    var path = GetOrCreateFilePath(fileFormat, dbName);
                    return File.ReadAllText(path) == string.Empty ? new List<Recipe>() : JsonSerializer.Deserialize<List<Recipe>>(File.ReadAllText(path));
                case FileFormat.Txt:
                    return new List<Recipe>();      
                default:
                    return new List<Recipe>();
            }
        }

        public static void SetInDb(FileFormat fileFormat, string dbName, List<Recipe> recipes)
        {
            switch (fileFormat)
            {
                case FileFormat.Json:
                    var path = GetOrCreateFilePath(fileFormat, dbName);
                    File.WriteAllText(path, JsonSerializer.Serialize(recipes));
                    break;
                case FileFormat.Txt:
                    break;
                default:
                    break;
            }
        }

        public static string GetOrCreateFilePath(FileFormat fileFormat, string name)
        {
            var path = name + fileFormat.GetStringValue();
            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path)) { }
            }
            return path;
        }
    }

    public class Recipe 
    {
        public string? Name { get; set; }
        public List<Ingredient>? Ingredients { get; set; }

        private string RecipeToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var Ingredient in Ingredients!)
            {
                sb.AppendLine($"\t{Ingredient.Name}\t\t{Ingredient.Instructions}");
            }
            return sb.ToString();
        }

        public override string? ToString()
        {
            return RecipeToString();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public class Ingredient
    {
        public int ID { get; }
        public string? Name { get; }
        public string? Instructions { get; }
    }

    public interface IRecipeBuilder
    {
        void SetName(string name);
        void AddIngredient(Ingredient instructions);
        Recipe GetRecipe();
    }

    public static class TextToFile
    {
        public static void SaveTextToFile(string text, string format)
        {

        }
    }

    public class TextRecipeBuilder : IRecipeBuilder
    {
        private Recipe Recipe = new Recipe();

        public Recipe GetRecipe()
        {
            return Recipe;
        }

        public void AddIngredient(Ingredient instructions)
        {
            Recipe.Ingredients!.Add(instructions);
        }

        public void SetName(string name)
        {
            Recipe.Name = name;
        }
    }

    public class JsonRecipeBuilder : IRecipeBuilder
    {
        private Recipe Recipe = new Recipe();

        public Recipe GetRecipe()
        {
            return Recipe;
        }

        public void AddIngredient(Ingredient instructions)
        {
            Recipe.Ingredients!.Add(instructions);
        }

        public void SetName(string name)
        {
            Recipe.Name = name;
        }
    }

    public class RecipeDirector
    {
        private readonly IRecipeBuilder? _builder;

        public RecipeDirector(IRecipeBuilder? builder)
        {
            _builder = builder;
        }

        public void ConstructRecipe(string name, List<Ingredient> ingredients)
        {
            _builder!.SetName(name);
            foreach (var ingredient in ingredients)
            {
                _builder.AddIngredient(ingredient);
            }
            
        }
    }
}
