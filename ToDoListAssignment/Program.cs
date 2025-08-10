System.Console.WriteLine("Hello!");

bool shallExit = false;
string userInput;
string[] possibleOptions = new string[] { "a", "A", "s", "S", "E", "e", "r", "R" };
List<string> toDoList = new List<string> {};

while (!shallExit)
{
  
do
{
  System.Console.WriteLine("What do you want to do?");
  System.Console.WriteLine("[S]ee all TODO's");
  System.Console.WriteLine("[A]dd a TODO");
  System.Console.WriteLine("[R]emove a TODO");
  System.Console.WriteLine("[E]xit");
  userInput = Console.ReadLine();
} while (!possibleOptions.Contains(userInput));

switch (userInput)
{
  case "E":
  case "e":
      Exit();
    break;
  case "S":
  case "s":
      SeeAllTodos();
    break;
  case "A":
  case "a":
      AddToDo();
    break;
  case "R":
  case "r":
      RemoveToDo();
    break;
  default:
    System.Console.WriteLine("oops");
    break;
  };
}


void SeeAllTodos()
{
  if (toDoList.Count == 0)
  {
    System.Console.WriteLine("You aint got shit to do cuzin");
  }
  else
  {
  System.Console.WriteLine("See all TODO's");
  for (int i = 0; i < toDoList.Count; i++)
  {
    System.Console.WriteLine($"{i + 1}: {toDoList[i]}");
  }
  }
}

List<string> AddToDo()
{
  string addedTask;
  System.Console.WriteLine("Add TODO");

  do
  {
    System.Console.WriteLine("What task would you like to add big dog?");
    addedTask = Console.ReadLine();
  } while (addedTask == "" || toDoList.Contains(addedTask));

  toDoList.Add(addedTask);
  System.Console.WriteLine("Task successfully added big dog!🐶");
  return toDoList;
}

List<string> RemoveToDo()
{
  int indexInput;
  string input;
  if (toDoList.Count == 0)
  {
    System.Console.WriteLine("Try adding some task's jackass.");
    return toDoList;
  }
  else
  {
    System.Console.WriteLine("Remove TODO");
    do
    {
      Console.Write("Which TODO task would you like to remove? ");
      SeeAllTodos();

      input = Console.ReadLine();

      // keep looping while input is NOT a valid index
    } while (!int.TryParse(input, out indexInput) ||
           indexInput < 1 ||
           indexInput > toDoList.Count);

    toDoList.RemoveAt(indexInput - 1);
    return toDoList;
  }
}

bool Exit()
{
  System.Console.WriteLine("Thank you! See you later alligator!");
  return shallExit = true;
}


Console.ReadKey();