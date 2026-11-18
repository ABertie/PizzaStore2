public class Toppings
{
    private Dictionary<string, Topping> Selection = [];

    public Toppings() { StandardSelction(); }

    private void StandardSelction()
    {
        Add(new("Tomato", 0));
        Add(new("Baked pizza with", 0));
        Add(new("Pineapple", 10));
        Add(new("Artichoke", 10));
        Add(new("Bell pepper", 10));
        Add(new("Pepper", 10));
        Add(new("Onion", 10));
        Add(new("Olives", 10));
        Add(new("Asparagus", 10));
        Add(new("Pesto", 10));
        Add(new("Chili", 10));
        Add(new("Garlic", 10));
        Add(new("Cheese", 15));
        Add(new("Ham", 15));
        Add(new("Mushrooms", 15));
        Add(new("Bacon", 15));
        Add(new("Cocktail sausages", 15));
        Add(new("Arugula", 15));
        Add(new("Fresh tomatoes", 15));
        Add(new("Parmigino", 15));
        Add(new("Meat sauce", 15));
        Add(new("Vegetables", 15));
        Add(new("Gorgonzola", 20));
        Add(new("Pepperoni", 20));
        Add(new("Anchovies", 20));
        Add(new("Shrimp", 20));
        Add(new("Strips of meat", 20));
        Add(new("Meat sausages", 20));
        Add(new("Fresh mozzarella", 20));
        Add(new("Parma ham", 20));
        Add(new("Mixed mushrooms", 20));
        Add(new("Mussels", 20));
    }

    public Topping Add(Topping topping)
    {
        Selection.Add(topping.Filing.ToLower(), topping);
        return topping;
    }

    public Topping Remove(string filing)
    {
        Topping topping = Selection[filing];
        Selection.Remove(filing);
        return topping;
    }

    public Topping Get(string filing)
    {
        return Selection[filing.ToLower()];
    }

    public List<Topping> GetList(string[] filings)
    {
        List<Topping> list = [];
        foreach (string filing in filings)
        { list.Add(Selection[filing.ToLower()]); }
        return list;
    }

    public List<Topping> GetAll()
    {
        return [.. Selection.Values];
    }

    public List<Topping> GetAllByPrice(int price)
    {
        List<Topping> list = [];
        foreach (Topping topping in Selection.Values)
        { if (topping.Price == price) { list.Add(topping); } }
        return list;
    }

    public void Print()
    {
        foreach (Topping topping in Selection.Values)
        {
            Console.WriteLine(topping);
        }
    }
}