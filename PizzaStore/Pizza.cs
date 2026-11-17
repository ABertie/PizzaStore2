public class Pizza
{
    public int Number;
    public string Name;
    public string Toppings;
    public int Price;

    public Pizza(int number, string name, string toppings, int price)
    {
        Number = number;
        Name = name;
        Toppings = toppings;
        Price = price;
    }

    public override string ToString()
    {
        return $$"""
            {{Number}}  {{Name + Name.Count() % 12 }}                {{Price}} kr.
                {{Toppings}}
            """;
    }
}