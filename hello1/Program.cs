using hello1;
using System;


Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine("hello world");
Console.Beep();

Console.WriteLine(MathsOps.add(100,99)+"=is sum of 100 and 99");
MathsOps math = new MathsOps();
Console.WriteLine(math.multiply(5,4) + "= is multiplication of 5 and 4");
Console.ReadKey();
