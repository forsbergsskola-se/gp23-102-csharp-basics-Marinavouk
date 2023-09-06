// See https://aka.ms/new-console-template for more information

Console.WriteLine("Give me a number");

string input = Console.ReadLine();
int i = int.Parse(input);
int m = i * 60 ;

Console.WriteLine($"{m}");