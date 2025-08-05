Console.WriteLine("Hello, World!");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO!");
Console.WriteLine("[R]emove a TODO!");
Console.WriteLine("[E]xit");

var userInput = Console.ReadLine();

void PrintSelectedOption(string selectedOption)
{
  System.Console.WriteLine("Selected option: " + selectedOption);
}

if (userInput == "S")
{
  PrintSelectedOption("See all TODO'S");
}
else if (userInput == "A")
{
  PrintSelectedOption("Add a TODO");
}
else if (userInput == "R")
{
  PrintSelectedOption("Remove a TODO");
}
else if (userInput == "E")
{
  PrintSelectedOption("Exit");
}
else
{
  System.Console.WriteLine("You fudged up dawg");
}

Console.ReadKey();