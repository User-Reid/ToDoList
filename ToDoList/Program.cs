List<string> UpperCaseList(List<string> words)
{
        var upperCaseList = new List<string> { };
        foreach (string word in words)
        {
                if (upperCaseList.Contains(word))
                {
                        continue;
                }

                if (IsUpperCase(word))
                {
                        upperCaseList.Add(word);
                }
        }
        return upperCaseList;
}

bool IsUpperCase(string word)
{
        foreach (char letter in word)
        {
                if (!char.IsUpper(letter))
                {
                        return false;
                }
        }
        return true;
}


        // for (int i = 0; i < words.Count; i++)
// {
//         string word = words[i];
//         foreach (char taco in word)
//         {
//                 bool isUpperCase = char.IsUpper(taco);
//                 if (isUpperCase == true)
//                 {
//                         banana.Add(word);
//                 }
//         }
// }

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