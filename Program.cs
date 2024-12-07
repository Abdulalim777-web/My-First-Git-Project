 
 
 try
 {

    Console.WriteLine("Enter 1 to access Addition\nEnter 2 to access Multiplication\nEnter 3 to access division\nEnter 5 to access subtraction");
    int value = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Welldone");
 
     Console.WriteLine("Enter your First number");
    double firstnum = double.Parse(Console.ReadLine()!);
 
    Console.WriteLine("Enter your second number");
    double secondnum = double.Parse(Console.ReadLine()!);

    switch (value)
    {
     case 1:
        double result1 = firstnum + secondnum;
        Console.WriteLine($"{result1}");
        break;
    case 2:
        double result2 = firstnum * secondnum;
        Console.WriteLine($"{result2}");
     break;
    case 3:
     double result3 = firstnum  / secondnum;
        Console.WriteLine($"{result3}");

     break;
    case 4:
            double result4 = firstnum - secondnum;
        Console.WriteLine($"{result4}");
     break; 
    default:
        Console.WriteLine ("input a valid number");
        break;

    }
 }
 catch(FormatException ex)
 {
    Console.WriteLine( "Format Error: {0}",ex.Message); 
 }
 catch(DivideByZeroException ex)
 {
    Console.WriteLine( "Division Error: {0}",ex.Message); 
 }
 catch(NullReferenceException ex)
 {
    Console.WriteLine( "Value Error: {0}",ex.Message);
 }
 catch(Exception ex)
 {
    Console.WriteLine( " Error: {0}",ex.Message);
 }
 
 
 