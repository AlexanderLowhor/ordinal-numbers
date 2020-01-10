using System;

class MainClass {
  public static void Main (string[] args) {

    Console.WriteLine("What is your number?");
    int UserNum = Int32.Parse(Console.ReadLine());
    
    switch (UserNum % 100) {
        case 11:
        Console.WriteLine($"{UserNum}th");
        break;

        case 12:

        Console.WriteLine($"{UserNum}th");
        break;

        case 13:
        Console.WriteLine($"{UserNum}th");
        break;
        
        default:
             switch (UserNum % 10) {
                 case 1:
                 Console.WriteLine($"{UserNum}st");
                 break;

                 case 2:
                 Console.WriteLine($"{UserNum}nd");
                 break;

                 case 3:
                 Console.WriteLine($"{UserNum}rd");
                 break;

                 default:
                 Console.WriteLine($"{UserNum}th");
                 break;
             }
        break;
    }

    int num2 = 0;

    do {
        num2++
    
    switch (num2 % 100) {
        case 11:
        Console.WriteLine($"{num2}th");
        break;

        case 12:

        Console.WriteLine($"{num2}th");
        break;

        case 13:
        Console.WriteLine($"{num2}th");
        break;
        
        default:
             switch (num2 % 10) {
                 case 1:
                 Console.WriteLine($"{num2}st");
                 break;

                 case 2:
                 Console.WriteLine($"{num2}nd");
                 break;

                 case 3:
                 Console.WriteLine($"{num2}rd");
                 break;

                 default:
                 Console.WriteLine($"{num2}th");
                 break;
    }

  }
}
  }

/*
1 2 R 1

2 5 R 2

3 10 R 3

*/