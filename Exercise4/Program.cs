// See https://aka.ms/new-console-template for more information
//Develop a program that calculates the area of a 
//circle using a float input for the radius and displays the result

Console.WriteLine("Give me the radious number ");
string radios = Console.ReadLine();
float r = float.Parse(radios);
double pi = 3.14159265359;

double a = pi * r*r ;

Console.WriteLine($"{a}");


