using System;

class MainClass {
  public static void Main (string[] args) {
    
    Console.WriteLine("What's the first input type?\n");
    Console.WriteLine("=======================================\n");
    Console.WriteLine("1 - Decimal");
    Console.WriteLine("2 - Binary");
    Console.WriteLine("3 - Hexadecimal"); 
    int firstInput = Convert.ToInt32(Console.ReadLine());
    string hexadecimal;
    int firstValue = 0;

    Console.WriteLine("Please Enter first value");
    if(firstInput == 3)
    {
      hexadecimal = Console.ReadLine();
    }
    else
    {
      firstValue = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("What's the second input type?\n");
    Console.WriteLine("=======================================\n");
    Console.WriteLine("1 - Decimal");
    Console.WriteLine("2 - Binary");
    Console.WriteLine("3 - Hexadecimal"); 
    int secondInput = Convert.ToInt32(Console.ReadLine());




  }
}
