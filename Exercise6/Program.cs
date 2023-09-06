// See https://aka.ms/new-console-template for more information
//Develop a program that takes two integers as input and
//calculates their product using the multiplication operator.

Console.WriteLine("Type 2 intigers");

string input1 = Console.ReadLine();
int one = int.Parse(input1);

string input2 = Console.ReadLine();
int two = int.Parse(input2);

int calc = one * two;

Console.WriteLine($"{calc}");
