using System;
using System.Collections.Generic;

namespace WaterShop
{
    internal class Ingredient
    {
        public string Name { get; set; }
        public int Quantity { get; private set; }

        public Ingredient(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public bool UseIngredient(int amount)
        {
            if (Quantity >= amount)
            {
                Quantity -= amount;
                return true;
            }
            return false;
        }

        public void Refill(int amount)
        {
            Quantity += amount;
        }
    }

    internal class CoffeeMachine
    {
        public Dictionary<string, Ingredient> Ingredients { get; private set; }

        public CoffeeMachine()
        {
            Ingredients = new Dictionary<string, Ingredient>
            {
                { "Water", new Ingredient("Water", 0) },
                { "Coffee", new Ingredient("Coffee", 0) },
                { "Hot_Milk", new Ingredient("Hot Milk", 0) },
                { "Chocolate", new Ingredient("Chocolate", 0) }
            };
        }

        public bool MakeCoffee(string coffeeType)
        {
            Dictionary<string, int> recipe = GetRecipe(coffeeType);
            if (recipe == null) return false;

            foreach (var item in recipe)
            {
                if (!Ingredients[item.Key].UseIngredient(item.Value))
                {
                    return false;
                }
            }
            return true;
        }

        private Dictionary<string, int> GetRecipe(string coffeeType)
        {
            if (coffeeType == "Late")
            {
                return new Dictionary<string, int>
        {
            { "Water", 300 },
            { "Coffee", 20 }
        };
            }
            else if (coffeeType == "Mocca")
            {
                return new Dictionary<string, int>
        {
            { "Water", 300 },
            { "Coffee", 20 },
            { "Chocolate", 10 }
        };
            }
            else if (coffeeType == "HotChocolate")
            {
                return new Dictionary<string, int>
        {
            { "Water", 300 },
            { "Chocolate", 10 }
        };
            }
            else if (coffeeType == "Black")
            {
                return new Dictionary<string, int>
        {
            { "Water", 300 },
            { "Coffee", 20 }
        };
            }
            else
            {
                return null;
            }
        }

    }
}