// See https://aka.ms/new-console-template for more information
//Develop a program that calculates the length of the hypotenuse of a
//right triangle using the lengths of the other two sides as inputs.
//Display the result.

Console.WriteLine("Type length of a side");
string side1 = Console.ReadLine();
float a = float.Parse(side1);

Console.WriteLine("Type length of the other side");
string side2 = Console.ReadLine();
float b = float.Parse(side2);

float calc = (a * a) + (b * b);

double tot = Math.Sqrt(calc);  

Console.WriteLine($"{tot}");



