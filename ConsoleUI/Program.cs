

// for (int i = 0; i < 20; i++)
// {
//   System.Console.WriteLine($"The value of i is {i}");
//   for (int j = 0; j < 10; j++)
//   {
//     System.Console.WriteLine($"The value of j is {j}");
//   }
// }

// int total = 0;

// for (int i = 0; i < 10; i++)
// {
//   total += i * 5;
// }


// ----------------------------- Handling Exceptions ----------------------------------------
// Eating an exception
// try
// {
//   BadCall();
// }
// catch (System.Exception ex)
// {
//   System.Console.WriteLine("Bad call found an exception");
//   System.Console.WriteLine(ex.Message);
//   throw new Exception();
// }



// static void BadCall()
// {
//   int[] ages = new int[] { 1, 4, 7 };

//   for (int i = 0; i <= ages.Length; i++)
//   {
//     try
//     {

//       System.Console.WriteLine(ages[i]);
//     }
//     catch (Exception ex)
//     {
//       System.Console.WriteLine("Exception was found");
//       System.Console.WriteLine(ex.Message);
//       throw new Exception("Exception found here", ex);
//     }
//   }

// }
// Console.ReadLine();

// *********************************ADVANCED EXCEPTIONS***********************************
// using System.Data;

// string name = "";
// try
// {
//   Console.Write("What's your name: ");
//   name = Console.ReadLine();
//   ComplexMethod(name);
//   SimpleMethod();
// }
// catch (Exception) when (name.ToLower() == "tim")
// {
//   System.Console.WriteLine("You are tim, yes?");
// }
// catch (System.Exception ex)
// {

//   Console.WriteLine(ex.Message);
// }
// finally
// {
//   System.Console.WriteLine("I am finally run every time");
// }


// static void SimpleMethod()
// {
//   throw new InvalidOperationException("Operation exception was found");
// }

// static void ComplexMethod(string name)
// {

//   if (name.ToLower() == "tim")
//   {
//     throw new EvaluateException();
//   }
//   else
//   {
//     throw new ArgumentException();
//   }
// }

// *********************************ADVANCED BREAKPOINTS***********************************

// RunsALot();


// static void RunsALot()
// {
//   int total = 0;
//   int test = 0;
//   for (int i = -1000; i <= 1000; i++)
//   {
//     total += i;
//     try
//     {

//       test = 5 / i;
//     }
//     catch (System.Exception)
//     {

//       System.Console.WriteLine("There was an exception");
//     }
//   }

//   System.Console.WriteLine($"The total is {total}");
// }


// Console.ReadLine();

// *********************************BREAKPOINTS MIN PROJECT***********************************

