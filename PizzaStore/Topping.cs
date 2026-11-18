public class Topping
{
    public string Filing;
    public int Price = 0;

    public Topping(string filing, int price)
    {
        Filing = filing;
        Price = price;
    }

    public Topping(string filing)
    {
        Filing = filing;
    }

    public override string ToString()
    {
        return $$"""
            {{Filing}} : {{Price}} kr.
            """;
    }
}