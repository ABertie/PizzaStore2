public class PizzaMenu
{
    private int NextId = 1;
    public Toppings Toppings = new();
    private Dictionary<int, Pizza> Selection = [];

    public PizzaMenu() { StandardSelction(); }

    private void StandardSelction()
    {
        Add("Margherita", ["Tomato", "Cheese"], 69);
        Add("Vesuvio", ["Tomato", "Cheese", "Ham"], 75);
        Add("Capricciosa", ["Tomato", "Cheese", "Ham", "Mushrooms"], 80);
        Add("Calzone", ["Baked pizza with", "Tomato", "Cheese", "Ham", "Mushrooms"], 80);
        Add("Quattro stagioni", ["Tomato", "Cheese", "Ham", "Mushrooms", "shrimp", "pepper"], 85);
        Add("Marinara", ["Tomato", "Cheese", "shrimp", "mussels", "garlic"], 85);
        Add("Vegetarian", ["Tomato", "Cheese", "vegetables"], 85);
        Add("Italiana", ["Tomato", "Cheese", "onion", "meat sauce"], 75);
        Add("Gorgonzola", ["Tomato", "gorgonzola", "onion", "mushrooms"], 85);
        Add("Contadina", ["Tomato", "Cheese", "mushrooms", "olives"], 75);

    }

    public Pizza Add(string name, string[] toppings, int price)
    {
        Pizza pizza = new Pizza(NextId++, name, Toppings.GetList(toppings), price);
        Selection.Add(pizza.Number, pizza);
        return Selection[pizza.Number];
    }

    public Pizza Remove(int number)
    {
        Pizza pizza = Selection[number];
        Selection.Remove(number);
        return pizza;
    }

    public Pizza Get(int number)
    {
        return Selection[number];
    }

    public List<Pizza> GetList(int from = 1, int to = 40)
    {
        List<Pizza> list = [];
        foreach (var pizza in Selection)
        {
            if (pizza.Key >= from && pizza.Key <= to)
            {
                list.Add(pizza.Value);
            }
        }
        return list;
    }

    public List<Pizza> GetAll()
    {
        return [.. Selection.Values];
    }

    public List<Pizza> Seach(string seachWord)
    {
        List<Pizza> list = [];
        foreach (Pizza pizza in Selection.Values)
        {
            if (pizza.Name.ToLower().Contains(seachWord.ToLower())) { list.Add(pizza); }
            else if (pizza.Toppings.Any(x => x.Filing.ToLower().Contains(seachWord.ToLower()))) { list.Add(pizza); }
        }
        return list;
    }

    public List<Pizza> PriceRange(int max = 200, int min = 0)
    {
        List<Pizza> list = [];
        foreach (Pizza pizza in Selection.Values)
        {
            if (pizza.Price >= min && pizza.Price <= max)
            {
                list.Add(pizza);
            }
        }
        return list;
    }

    public void Print()
    {
        foreach (Pizza pizza in Selection.Values)
        {
            Console.WriteLine(pizza);
        }
    }
}