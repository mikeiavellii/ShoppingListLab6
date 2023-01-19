Console.WriteLine("Welcome to Chirpus Market!\n");

//Cart contains user selected item name
List<string> Cart = new List<string>();

//Price contains user selected item price
List<decimal> Price = new List<decimal>();
Dictionary<string, decimal> menu = new Dictionary<string, decimal>()
{
  { "apple", 0.99m} ,
  { "banana", 0.59m},
  { "eggs", 6.59m},
  { "milk", 2.19m},
  { "kale", 1.79m},
  { "fig", 2.09m},
  { "grapefruit", 1.99m},
  { "honeydew", 3.49m},
};
Console.WriteLine("Item\t\tPrice\n" +
 "======================");
foreach (KeyValuePair<string, decimal> kvp in menu)
{
  Console.WriteLine($"{kvp.Key}     \t${ kvp.Value}");
}

bool runProgram = true;
bool runProgram1 = false;
Console.WriteLine("\nPlease enter an item name.");
while (runProgram)
{
  string response = Console.ReadLine();

  //take user input
  if (menu.ContainsKey(response))
  {
    Cart.Add(response);
    Price.Add(menu[response]);
    Console.WriteLine($"{response} has been added to your cart at ${menu[response]}.");
    runProgram1 = true;
  }
  else
  {
    Console.WriteLine("\n" +
  "Item\t\tPrice\n" +
   "======================");
    foreach (KeyValuePair<string, decimal> kvp in menu)
    {
      Console.WriteLine($"{kvp.Key}     \t${ kvp.Value}");
    }

    Console.WriteLine($"{response} is not a valid selection. Please select an item from the list above:");
  }
 
  //ask continue
  while (runProgram1)
  {
    Console.WriteLine("Do you want to add anything else to your cart? (y/n)");
    string answer = Console.ReadLine();
    if (answer == "y")
    {
      Console.WriteLine("Item\t\tPrice\n" +
          "======================");
      foreach (KeyValuePair<string, decimal> kvp in menu)
      {
        Console.WriteLine($"{kvp.Key}     \t${ kvp.Value}");
      }
      Console.WriteLine("\nPlease enter an item name.");
      runProgram1 = true;
      break;
    }
    else if (answer == "n")
    {
      runProgram = false;
      runProgram1 = false;
      break;
    }
    else
    {
      Console.WriteLine($"{answer} is not a valid selection. Please enter either y or n.");
    }
  }
}
Console.WriteLine("Thanks for your order! Here's what you bought:");
Console.WriteLine("" +
"Item\t\tPrice\n======================");
foreach (string s in Cart)
{
  Console.WriteLine($"{s}     \t${menu[s]}");
}

decimal total = Price.Sum();
decimal mostE = Price.Max();
decimal leastE = Price.Min();
Console.WriteLine($"\nYour total is: ${total}");
Console.WriteLine($"Your most expensive item was {mostE}");
Console.WriteLine($"Your least expensive item was {mostE}");