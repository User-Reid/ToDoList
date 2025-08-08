int userNumber;

do
{
  System.Console.WriteLine("Please enter a number larger than 10😀!");
  string taco = Console.ReadLine();

  if (taco == "stop")
  {
    break;
  }
  userNumber = int.Parse(taco);
} while (userNumber <= 10);

System.Console.WriteLine("The loop is finished");
Console.Read();

// string word;

// do
// {
//         System.Console.WriteLine("Enter a word longer than 10 letters");
//         word = System.Console.ReadLine();
// }
// while (word.Length <= 10);

// System.Console.WriteLine("The loop is finished");
// Console.ReadKey();

// Console.WriteLine("Hello, World!");
// Console.WriteLine("[S]ee all TODOs");
// Console.WriteLine("[A]dd a TODO!");
// Console.WriteLine("[R]emove a TODO!");
// Console.WriteLine("[E]xit");

// var userInput = Console.ReadLine();

// switch (userInput)
// {
//   case "S":
//   case "s":
//     PrintSelectedOption("See all TODO's");
//     break;
//   case "A":
//   case "a":
//     PrintSelectedOption("Add a TODO");
//     break;
//   case "R":
//   case "r":
//     PrintSelectedOption("Remove a TODO");
//     break;
//   case "E":
//   case "e":
//     PrintSelectedOption("Exit");
//     break;
//   default:
//     Console.WriteLine("Dog you messed up hard af fam😩");
//     break;
// }

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

Console.ReadKey();