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

System.Console.WriteLine("The Do-While loop is done.");

switch (userInput)
{
  case "E":
  case "e":
    System.Console.WriteLine("Exit");
    shallExit = true;
    break;
  case "S":
  case "s":
    System.Console.WriteLine("See all TODO's");
      SeeAllTodos();
    break;
  case "A":
  case "a":
    System.Console.WriteLine("Add TODO");
      AddToDo();
    break;
  case "R":
  case "r":
    System.Console.WriteLine("Exit");
      RemoveToDo();
    break;
  default:
    System.Console.WriteLine("oops");
    break;
  };
}


void SeeAllTodos()
{
  for (int i = 0; i < toDoList.Count; i++)
  {
    System.Console.WriteLine($"{i + 1}: {toDoList[i]}");
  }
}

List<string> AddToDo()
{
  string addedTask;
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
  do
  {
    System.Console.WriteLine("Which TODO task would you like to remove 🥲");
    SeeAllTodos();
    string stringInput = Console.ReadLine();
    indexInput = int.Parse(stringInput);
  } while (indexInput > toDoList.Count - 1 && indexInput < 0);

  toDoList.RemoveAt(indexInput - 1);
  return toDoList;
}

void Exit()
{
  System.Console.WriteLine("Thank you! See you later alligator!");
}


Console.ReadKey();