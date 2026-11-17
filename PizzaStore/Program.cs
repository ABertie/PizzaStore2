Dictionary<int, Pizza> Menu = new();
Menu.Add(1, new Pizza(1, "Margherita", "Tomato & cheese", 69));
Menu.Add(2, new Pizza(2, "Vesuvio", "Tomato, cheese & ham", 75));
Menu.Add(3, new Pizza(3, "Capricciosa", "Tomato, cheese, ham & mushrooms", 80));

Order firstOrder = new(new Customer("Phill"), Menu[1], 2);
firstOrder.Print();

Order SecondOrder = new(new Customer("Dorte"), Menu[3]);
SecondOrder.Print();

Order ThirdOrder = new(new Customer("Elsa"), Menu[2], "Peperoni");
ThirdOrder.Print();
