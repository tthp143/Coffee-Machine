# Coffee-Machine

![MyUI](https://github.com/user-attachments/assets/b1f26400-3033-42ee-9587-f0b9e0a062d0)
//รูปแบบUI


internal class Ingredient //สร้างclassที่มีชื่อว่าIngredientเป็นคลาสที่มีองค์ประกอบของวัตถุดิบต่างๆ
    {
        public string Name { get; set; }
        public int Quantity { get; private set; }

        public Ingredient(string name, int quantity) //ทำฟังก์ชั่นที่เก็บค่าชื่อและจำนวนวัตถุดิบ
        {
            Name = name;
            Quantity = quantity;
        }

        public bool UseIngredient(int amount)  //ทำฟังก์ชั่นที่ตรวจสอบว่าวัตถุดิบเพียงพอหรือไม่
        {
            if (Quantity >= amount)
            {
                Quantity -= amount;
                return true;
            }
            return false;
        }

        public void Refill(int amount) //ฟังก์ชั่นเพิ่มวัตถุดิบ
        {
            Quantity += amount;
        }
    }

    internal class CoffeeMachine //สร้างclassที่แทนเครื่องcoffee machine มีองค์ประกอบเกี่ยวกับฟังก์ชั่นที่เครื่องสามารถทำงานได้ เช่นกำหนดค่าวัตถุดิบ
    {
        public Dictionary<string, Ingredient> Ingredients { get; private set; } //ฟังก์ชั่นเก็บค่าตัวแปรและจำนวนวัตถุดิบ

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
