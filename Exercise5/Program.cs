// See https://aka.ms/new-console-template for more information

//Write a program that takes an integer input and
//displays its negation using the unary minus operator.*

Console.WriteLine("Type an input");
string input = Console.ReadLine();
int i = int.Parse(input);
int x = -i;

Console.WriteLine($"{x}");