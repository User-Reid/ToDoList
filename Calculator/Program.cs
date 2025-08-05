System.Console.WriteLine("Hello!");
System.Console.WriteLine("Input the first number!");

string number1 = System.Console.ReadLine();

System.Console.WriteLine("Input the second number!");

string number2 = System.Console.ReadLine();

System.Console.WriteLine("What do you want to do with those numbers?");
System.Console.WriteLine("[A]dd");
System.Console.WriteLine("[S]ubtract");
System.Console.WriteLine("[M]ultiply");

string userInput = System.Console.ReadLine();

Calculate(userInput, number1, number2);

void Calculate(string userInput, string a, string b)
{
  if (userInput == "A" || userInput == "a")
  {
    System.Console.WriteLine($"{a} + {b} = {int.Parse(a) + int.Parse(b)}");
  }
  else if (userInput == "S" || userInput == "s")
  {
    System.Console.WriteLine($"{a} - {b} = {int.Parse(a) - int.Parse(b)}");
  }
  else if (userInput == "M" || userInput == "m")
  {
    System.Console.WriteLine($"{a} * {b} = {int.Parse(a) * int.Parse(b)}");
  }
  else
  {
    System.Console.WriteLine("You done fudged up cousin.");
  }
}

System.Console.WriteLine("Press any button to close.");
Console.Read();


