int choice;
List<Burger> burgers = new List<Burger>();
List<Side> sides = new List<Side>();
List<Wrap> wraps = new List<Wrap>();

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
    burgers.Add(burger);

    Console.WriteLine($"Burger with {extraPatties} extra patties, {(extraCheese > 0 ? extraCheese : "no")} extra cheese slices added, and {(hasVeggies ? "" : "no")} veggies added! Subtotal: {burger.cost} PHP");
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

    int mediumCost = -1;
    int largeCost = -1;
    switch (type)
    {
        case 1:
            mediumCost = 50;
            largeCost = 75;
            break;
        case 2:
            mediumCost = 60;
            largeCost = 90;
            break;
        case 3:
            mediumCost = 70;
            largeCost = 105;
            break;
    }
    do
    {
        Console.WriteLine($"""
        Please select a size:
        (1) Medium ({mediumCost} PHP)
        (2) Large ({largeCost} PHP)
        """);
        input = Console.ReadLine();
    } while (!int.TryParse(input, out size) || size < 1 || size > 2);

    Side side = new Side(type, size);
    sides.Add(side);

    Console.WriteLine($"{side.size} {side.type} added! Subtotal: {side.cost} PHP");
}
void OrderWrap()
{
    string? input;
    bool isAllMeat;
    int extraCheese;
    int spiceLevel;

    do
    {
        Console.Write("Would you like your wrap to be all meat? (y/n): ");
        input = Console.ReadLine();
    } while (input != "y" && input != "n");
    isAllMeat = input == "y";

    do
    {
        Console.Write("Please enter the number of extra cheese you would like to add (20 PHP per slice): ");
        input = Console.ReadLine();
    } while (!int.TryParse(input, out extraCheese) || extraCheese < 0);

    do
    {
        Console.WriteLine("""
        Please select a spice level:
        (1) Mild
        (2) Spicy
        (3) Very Spicy
        """);
        input = Console.ReadLine();
    } while (!int.TryParse(input, out spiceLevel) || spiceLevel < 1 || spiceLevel > 3);

    Wrap wrap = new Wrap(extraCheese, isAllMeat, spiceLevel);
    wraps.Add(wrap);

    string res = $"{(isAllMeat ? "All meat" : "")} {wrap.spiceLevel?.ToLower()} wrap with {(extraCheese > 0 ? extraCheese : "no")} extra cheese added! Subtotal: {wrap.cost} PHP".Trim();
    Console.WriteLine($"{char.ToUpper(res[0])}{res[1..]}");
}
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

class Wrap
{
    public int extraCheese;
    public bool isAllMeat;
    public string? spiceLevel;
    public int cost;
    public Wrap(int extraCheese, bool isAllMeat, int spiceLevel)
    {
        this.extraCheese = extraCheese;
        this.isAllMeat = isAllMeat;
        switch (spiceLevel)
        {
            case 1: this.spiceLevel = "Mild"; break;
            case 2: this.spiceLevel = "Spicy"; break;
            case 3: this.spiceLevel = "Very Spicy"; break;
        }
        this.cost = 100 + 20 * extraCheese;
    }
}