

// System.Console.Write("What's your name? ");
// string firstName = Console.ReadLine();


// switch (firstName.ToLower())
// {

//   case "tim":
//     System.Console.WriteLine("Hi a Professor");
//     break;
//   default:
//     System.Console.WriteLine("Hi Student");
//     break;
// }


// -----------------LIST-----------------------------------
// List<string> students = new List<string>();
// bool isFinished = false;

// do
// {
//   System.Console.Write("Please enter a student name(Or type exit quit) ");
//   string? student = Console.ReadLine();
//   if (student != null && student != "exit" && student.Trim() != "")
//   {
//     students.Add(student);
//   }
//   else
//   {
//     isFinished = true;
//   }
// } while (!isFinished);

// System.Console.WriteLine($"There are {students.Count} students in this class");





// ---------------------DICTIONARIES---------------------------

// Dictionary<string, string> lookup = new Dictionary<string, string>();

// lookup["dog"] = "bark bark";
// lookup["cat"] = "meow meow";
// lookup["cow"] = "mu mu";

// System.Console.WriteLine($"The cat is invoke sound {lookup["cat"]}");

// Dictionary<int, string> employees = new Dictionary<int, string>();

// employees[95] = "Tim Corey";
// employees[28] = "Sue Storm";
// employees[33] = "Bob Mikey";
// employees[28] = "Richards Sam";

// bool isDone = false;
// do
// {

//   Console.Write("Type an ID of a employee(Or type exit if you done): ");
//   string? idText = Console.ReadLine();
//   bool isIDRight = int.TryParse(idText, out int id);

//   if (idText == "exit")
//   {
//     isDone = true;
//     break;
//   }

//   if (!isIDRight)
//   {
//     System.Console.WriteLine("Pleas type correct id");
//     continue;
//   }

//   if (employees.ContainsKey(id))
//   {

//     System.Console.WriteLine($"The employee with id {id} is {employees[id]}");
//   }
//   else
//   {
//     System.Console.WriteLine($"There is no employee with this id {id}");
//   }

// } while (!isDone);





// ----------------------- FOR LOOPS ---------------------------------------

// List<decimal> charges = new();

// charges.Add(25.78M);
// charges.Add(12.33M);
// charges.Add(149M);
// charges.Add(8.19M);

// decimal total = 0;

// for (int i = 0; i < charges.Count; i++)
// {
//   total += charges[i];
// }

// System.Console.WriteLine($"The total of charges is {total}");


// Console.Write("Please write comma-separated list of first names ");
// string? firstNamesText = Console.ReadLine();
// List<string> firstNames = firstNamesText.Trim().Split(',').ToList();

// for (int i = 0; i < firstNames.Count; i++)
// {
//   System.Console.WriteLine($"Hello {firstNames[i]}");
// }



// ------------------------------ FOREACH LOOP -------------------------------------------------


// string data = "Tim,Bob,Sue,Jane";
// List<string> firstNames = data.Split(',').ToList();


// foreach (string firstName in firstNames)
// {
//   System.Console.WriteLine(firstName);
// }


// HW Foreach loops

// List<string> firstNames = new();

// bool isDone = false;

// do
// {
//   System.Console.Write("Please write name(or exit if you done) ");
//   string? firstName = Console.ReadLine().Trim();

//   if (firstName == "exit")
//   {
//     isDone = true;
//   }
//   else
//   {

//     firstNames.Add(firstName);
//   }

// } while (!isDone);


// foreach (string firstName in firstNames)
// {
//   System.Console.WriteLine($"Hello {firstName}");
// }



// --------------------------------METHODS----------------------------------------------
// 1. Creating a Method


// using HelloWorld;

// string name = ConsoleMessages.GetUserName();

// ConsoleMessages.SayHi(name);

// double result = MathShortcuts.Add(12, 33);
// Console.WriteLine($"The result of adding {result}");


// double[] nums = new double[] { 12, 22, 3, 44, 50 };
// double sumOfNums = MathShortcuts.AddAll(nums);
// System.Console.WriteLine($"The sum of numbers is {sumOfNums}");

// ConsoleMessages.SayGoodbye();

// using HelloWorld;

//  Discard character (_), underscore
// (string firstName, _) = ConsoleMessages.GetFullName();

// System.Console.WriteLine($"First name is: {firstName}");
// System.Console.WriteLine($"Last name is: {lastName}");

// Console.Write("Please write a number: ");
// string numberText = Console.ReadLine();
// (bool isValid, int num) = ConsoleMessages.OwnTryParse(numberText);
// Console.Write($"This number is valid {isValid} and number is {num}");

// HomeWork
// ConsoleMessages.Welcome();
// string name = ConsoleMessages.AskUserName();
// ConsoleMessages.SayHelloUser(name);












