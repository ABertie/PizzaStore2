public class Order
{
    public Customer Customer;
    public Pizza Pizza;
    public int PizzaCount = 1;
    public string ExtraTopping;
    public int ExtraToppingPrice = 10;
    //public double VAT = 0.25;
    public int DeliveryCosts = 40;

    public Order(Customer customer, Pizza pizza)
    {
        Customer = customer;
        Pizza = pizza;
    }

    public Order(Customer customer, Pizza pizza, int count)
    {
        Customer = customer;
        Pizza = pizza;
        PizzaCount = count;
    }

    public Order(Customer customer, Pizza pizza, string extraToping)
    {
        Customer = customer;
        Pizza = pizza;
        ExtraTopping = extraToping;
    }

    public Order(Customer customer, Pizza pizza, int count, string extraToping)
    {
        Customer = customer;
        Pizza = pizza;
        ExtraTopping = extraToping;
        PizzaCount = count;
    }

    public double CalculateTotalPrice()
    {
        double TotalPrice = Pizza.Price * PizzaCount;
        if (ExtraTopping != null) { TotalPrice += ExtraToppingPrice; }
        TotalPrice += DeliveryCosts;
        //TotalPrice *= (1 + VAT);
        return TotalPrice;
    }

    public void Print()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        string NameSpace = "";
        for (int i = 0; i < 15 - Pizza.Name.Length; i++) { NameSpace += " "; }

        string TopingSpace = "";
        string IfExtraToping = "";
        if (ExtraTopping != null)
        {
            for (int i = 0; i < 15 - ExtraTopping.Length; i++) { TopingSpace += " "; }
            IfExtraToping = $"   + {ExtraTopping + TopingSpace}             {ExtraToppingPrice} kr.";
        }

        return $$"""

                          Big Mamma
                         Gastronomia

            Customer : {{Customer}}

            {{PizzaCount}} x #{{Pizza.Number}} {{Pizza.Name + NameSpace}}           {{Pizza.Price * PizzaCount}} kr.
            {{IfExtraToping}}

            Delivery                         {{DeliveryCosts}} kr.
            ---------------------------------------
            Total:                          {{CalculateTotalPrice()}} kr.
            
            Moms 25% - BRUTTO               {{CalculateTotalPrice()}} kr.
            Moms 25% - NETTO                {{Math.Round(CalculateTotalPrice() * 0.8, 2)}} kr.
            Moms 25% - MOMS                 {{Math.Round(CalculateTotalPrice() * 0.2, 2)}} kr.

            """;
    }
}