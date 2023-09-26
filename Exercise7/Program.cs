// See https://aka.ms/new-console-template for more information
//Develop a program that calculates the BMI of a person using
//their weight in kilograms and height in meters. Display the BMI value.

Console.WriteLine("Give me your weight in kg");
string kilo = Console.ReadLine();
float kilog = float.Parse(kilo);

Console.WriteLine("Give me your height in meters");
string height = Console.ReadLine();
float h = float.Parse(height);

float calc = kilog / (h * h);

Console.WriteLine($"{calc}");