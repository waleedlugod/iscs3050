int totalCost = 0;
int choice;
List<Burger> burgers = new List<Burger>();
List<Side> sides = new List<Side>();

do
{
    Console.WriteLine("""
    Please choose an option
    (1) Burger (50 PHP)
    (2) Side (Varies)
    (3) Wrap (100 PHP)
    (4) View items
    (5) Remove an item
    (6) Finish Order
    """);

    string? input = Console.ReadLine();
    Console.WriteLine();

    if (int.TryParse(input, out choice))
    {
        switch (choice)
        {
            case 1: OrderBurger(); break;
            case 2: OrderSide(); break;
            case 3: OrderWrap(); break;
            case 4: ViewItems(); break;
            case 5: RemoveItem(); break;
            case 6: FinishOrder(); break;
        }
        Console.WriteLine();
    }
} while (choice != 6);

void OrderBurger()
{
    string? input;
    int extraPatties = 0;
    int extraCheese = 0;
    bool hasVeggies = false;

    do
    {
        Console.Write("Please enter the number of extra patties you wish to add (50 PHP per slice): ");
        input = Console.ReadLine();
    } while (!int.TryParse(input, out extraPatties) || extraPatties < 0);

    do
    {
        Console.Write("Please enter the number of extra cheese slices you wish to add (25 PHP per slice): ");
        input = Console.ReadLine();
    } while (!int.TryParse(input, out extraCheese) || extraCheese < 0);

    do
    {
        Console.Write("Would you like veggies (y/n)?: ");
        input = Console.ReadLine();
    } while (input != "y" && input != "n");
    hasVeggies = input == "y";

    Burger burger = new Burger(extraPatties, extraCheese, hasVeggies);
    totalCost += burger.cost;
    burgers.Add(burger);

    Console.WriteLine($"Burger with {extraPatties} extra patties, {extraCheese} extra cheese slices added, and {(hasVeggies ? "" : "no")} veggies added! Subtotal: {burger.cost} PHP");
}

void OrderSide()
{
    string? input;
    int type;
    int size;

    do
    {
        Console.WriteLine("""
        Please choose a side
        (1) Fries (50 PHP for Medium, 75 PHP for Large)
        (2) Onion Rings (60 PHP for Medium, 90 PHP for Large)
        (3) Bacon Chips (70 PHP for Medium, 105 PHP for Large)
        """);
        input = Console.ReadLine();
    } while (!int.TryParse(input, out type) || type < 1 || type > 3);

    do
    {
        Console.Write("What size (m/l)?: ");
        input = Console.ReadLine();
    } while (input != "m" && input != "l");
    size = input == "m" ? 1 : 2;

    Side side = new Side(type, size);
    sides.Add(side);

    Console.WriteLine($"{side.size} {side.type} added! Subtotal: {side.cost} PHP");
}
void OrderWrap() { }
void ViewItems() { }
void RemoveItem() { }
void FinishOrder() { }

class Burger
{
    public int extraPatties;
    public int extraCheese;
    public bool hasVeggies;
    public int cost;
    public Burger(int extraPatties, int extraCheese, bool hasVeggies)
    {
        this.extraPatties = extraPatties;
        this.extraCheese = extraCheese;
        this.hasVeggies = hasVeggies;
        cost = 50 + 50 * extraPatties + 25 * extraCheese;
    }
}

class Side
{
    public string? type;
    public string? size;
    public int cost;
    public Side(int type, int size)
    {
        switch (type)
        {
            case 1: this.type = "Fries"; break;
            case 2: this.type = "Onion Rings"; break;
            case 3: this.type = "Bacon Chips"; break;
        }
        switch (size)
        {
            case 1: this.size = "Medium"; break;
            case 2: this.size = "Large"; break;
        }
        switch (this.type)
        {
            case "Fries": cost = this.size == "Medium" ? 50 : 75; break;
            case "Onion Rings": cost = this.size == "Medium" ? 60 : 90; break;
            case "Bacon Chips": cost = this.size == "Medium" ? 70 : 105; break;
        }
    }
}