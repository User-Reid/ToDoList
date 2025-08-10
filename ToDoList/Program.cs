var numbers = new[] { 10, -8, 2, 12, -17 };
int nonPositiveCount;
var onlyPositive = GetOnlyPositive(numbers, out nonPositiveCount);
foreach (var positiveNumber in onlyPositive)
{
        System.Console.WriteLine($"{positiveNumber}");
}
System.Console.WriteLine($"{nonPositiveCount}");



Console.ReadKey();

List<int> GetOnlyPositive(int[] numbers, out int countOfNonPositive)
{
        countOfNonPositive = 0;
        var result = new List<int>();

        foreach (int number in numbers)
        {
                if (number > 0)
                {
                        result.Add(number);
                }
                else
                {
                        countOfNonPositive++;
                }
        }
        return result;
}

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