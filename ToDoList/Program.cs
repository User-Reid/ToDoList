int FindMax(int[,] numbers)
{
        if (numbers.GetLength(0) == 0 || numbers.GetLength(1) == 0)
        {
                return -1;
        }

        int max = numbers[0, 0];
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                        int taco = numbers[i, j];
                        if (taco > max)
                        {
                                max = taco;
                        }
                }
        }
        return max;
}

System.Console.WriteLine($"{FindMax(new int[,] {{2,6}, {38,9}, {892, 43}, {1,1}})}");

Console.ReadKey();

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