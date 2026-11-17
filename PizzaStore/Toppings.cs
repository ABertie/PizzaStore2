public class Toppings
{
    private Dictionary<string, Topping> Selection = [];

    public Toppings() { StandardSelction(); }

    public Topping Add(Topping topping)
    {
        Selection.Add(topping.Filing, topping);
        return topping;
    }

    private void StandardSelction()
    {
        Selection.Add("Tomato", new("Tomato", 10));
        Selection.Add("Chesse", new("Chesse", 10));
    }

    public Topping Remove(string filing)
    {
        Topping topping = Selection[filing];
        Selection.Remove(filing);
        return topping;
    }

    public Topping Get(string filing)
    {
        return Selection[filing];
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