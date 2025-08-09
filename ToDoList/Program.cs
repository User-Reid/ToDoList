char[,] letters = new char[2, 3];

letters[0, 0] = 'A';
letters[0, 1] = 'B';
letters[0, 2] = 'C';
letters[1, 0] = 'D';
letters[1, 1] = 'E';
letters[1, 2] = 'F';

var height = letters.GetLength(0);
var width = letters.GetLength(1);
System.Console.WriteLine($"Height is {height}");
System.Console.WriteLine($"Width is {width}");

for (int i = 0; i < height; i++)
{
        // System.Console.WriteLine($"Yo, the height is {i}");
        for (int j = 0; j < width; j++)
        {
                // System.Console.WriteLine($"Ayo, the width is {j}");
                System.Console.WriteLine($"Ayo, the letters in the 2 dimentional array are {letters[i,j]} with the dimensions being {width}x{height}");
        }
}

var letters2 = new char[,]
{
        {'A', 'B', 'D'},
        {'D', 'E', 'F'},
};



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