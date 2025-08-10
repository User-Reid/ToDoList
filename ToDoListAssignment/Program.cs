List<string> toDoList = new List<string> { };
bool hasExited = false;
string userInput;


System.Console.WriteLine("Howdy, welcome to the TODO list maker!");

do
{
  System.Console.WriteLine("What would you like to do!");
  System.Console.WriteLine("[S]ee all TODO's");
  System.Console.WriteLine("[A]dd a TODO");
  System.Console.WriteLine("[R]emove a TODO");
  System.Console.WriteLine("[E]xit");
  userInput = Console.ReadLine();

  switch (userInput)
  {
    case "s":
    case "S":
      SeeAllTodo();
      break;
    case "a":
    case "A":
      AddTodo();
      break;
    case "R":
    case "r":
      RemoveTodo();
      break;
    case "e":
    case "E":
      Exit();
      break;
    default:
      System.Console.WriteLine("Please enter a valid option idiot.");
      break;
  }
} while (!hasExited);

void SeeAllTodo()
{
  if (toDoList.Count == 0)
  {
    System.Console.WriteLine("You have no TODO list items jackass.");
  }
  else
  {
    System.Console.WriteLine("Here is your currenct TODO list!");
    for (int i = 0; i < toDoList.Count; i++)
    {
      System.Console.WriteLine($"{i + 1}: {toDoList[i]}");
    }
  }
}

void RemoveTodo()
{
  string userIndex;
  int index;

  do
  {
    System.Console.WriteLine("Which TODO would you like to remove?");
    SeeAllTodo();
    userIndex = Console.ReadLine();
    index = int.Parse(userIndex);
  } while (index <= 0 || index > toDoList.Count);

  toDoList.RemoveAt(index - 1);
  System.Console.WriteLine("Your list has been successfully updated!");
}

void Exit()
{
  System.Console.WriteLine("See ya later alligator!🐊");
  hasExited = true;
}

void AddTodo()
{
  string userInput;

  do
  {
    System.Console.WriteLine("What TODO task would you like to add?");
    userInput = Console.ReadLine();

    if (userInput == "")
    {
      System.Console.WriteLine("Please type literally anything, idiot...");
    }
    else if (toDoList.Contains(userInput))
    {
      System.Console.WriteLine("You already have that as a task jackass...");
    }
  } while (userInput == "" || toDoList.Contains(userInput));

  toDoList.Add(userInput);
  System.Console.WriteLine("TODO has been successfully added!😃");
}

Console.ReadKey();