System.Console.WriteLine("Provide a number!");
string userInput = System.Console.ReadLine();
int number = int.Parse(userInput);
System.Console.WriteLine(number);

// Console.WriteLine("Hello, World!");
// Console.WriteLine("[S]ee all TODOs");
// Console.WriteLine("[A]dd a TODO!");
// Console.WriteLine("[R]emove a TODO!");
// Console.WriteLine("[E]xit");

// var userInput = Console.ReadLine();

// void PrintSelectedOption(string selectedOption)
// {
//   System.Console.WriteLine("Selected option: " + selectedOption);
// }

// if (userInput == "S")
// {
//   PrintSelectedOption("See all TODO'S");
// }
// else if (userInput == "A")
// {
//   PrintSelectedOption("Add a TODO");
// }
// else if (userInput == "R")
// {
//   PrintSelectedOption("Remove a TODO");
// }
// else if (userInput == "E")
// {
//   PrintSelectedOption("Exit");
// }
// else
// {
//   System.Console.WriteLine("You fudged up dawg");
// }

int Add(int a, int b)
{
  return a + b;
}

bool IsLong(string input)
{
  return input.Length > 10;
}

bool isLong = IsLong(userInput);
System.Console.WriteLine(isLong);

var banana = Add(12, 15);
System.Console.WriteLine("12 + 15 = " + banana);

Console.ReadKey();