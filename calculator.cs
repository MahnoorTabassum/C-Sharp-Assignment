/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());
    
    int add = num1 + num2;
    int sub = num1 - num2;
    int multi = num1 * num2;
    int div = num1 / num2;
    int rem = num1 % num2;
    int avg = (num1 + num2)/100;
    int sqr = num1 * num2;
    
    Console.WriteLine(add);
    Console.WriteLine(sub);
    Console.WriteLine(multi);
    Console.WriteLine(div);
    Console.WriteLine(rem);
    Console.WriteLine(avg);
    Console.WriteLine(sqr);
  }
}




