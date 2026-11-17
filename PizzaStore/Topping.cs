public class Topping
{
    public string Filing;
    public int Price;

    public Topping(string filing, int price)
    {
        Filing = filing;
        Price = price;
    }

    public override string ToString()
    {
        return $$"""
            {{Filing}} : {{Price}} kr.
            """;
    }
}