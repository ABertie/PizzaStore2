public class Pizza
{
    public int Number;
    public string Name;
    public List<Topping> Toppings;
    public int Price;

    public Pizza(int number, string name, List<Topping> toppings, int price)
    {
        Number = number;
        Name = name;
        Toppings = toppings;
        Price = price;
    }

    public override string ToString()
    {
        string toppings = "";
        foreach (Topping topping in Toppings) {
            if (toppings == "") { toppings += topping.Filing; }
            else { toppings += ", " + topping.Filing; }
        }

        return $$"""
            {{Number}}{{String.Concat(Enumerable.Repeat(" ", 4 - Number.ToString().Length))}}{{Name.ToUpper()}} {{String.Concat(Enumerable.Repeat(".", 50 - Name.Length))}} {{Price}} kr.
                 {{toppings}}

            """;
    }
}