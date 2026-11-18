PizzaMenu Menu = new();

//Menu.Print();
PrintPizzas(Menu.PriceRange(80, 70));
PrintLine();
PrintPizzas(Menu.Seach("ca"));
PrintLine();
PrintPizzas(Menu.GetList(5, 10));

static void PrintPizzas(List<Pizza> list)
{
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}

void PrintLine()
{
    Console.WriteLine("----------------------------");
    Console.WriteLine();
}

//Order firstOrder = new(new Customer("Phill"), Menu[1], 2);
//firstOrder.Print();

//Order SecondOrder = new(new Customer("Dorte"), Menu[3]);
//SecondOrder.Print();

//Order ThirdOrder = new(new Customer("Elsa"), Menu[2], "Peperoni");
//ThirdOrder.Print();
