// See https://aka.ms/new-console-template for more information
//Develop a program that calculates the area of a 
//circle using a float input for the radius and displays the result

Console.WriteLine("Give me the radius number ");

float radius = float.Parse(Console.ReadLine());
double pi = 3.14159265359;

double area = pi * radius*radius ; //Math.pi or MathF for float

Console.WriteLine($"{area}");


