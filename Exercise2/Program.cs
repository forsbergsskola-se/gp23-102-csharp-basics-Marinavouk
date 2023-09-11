// See https://aka.ms/new-console-template for more information

Console.WriteLine("Give me 2 numbers");
string input1 = Console.ReadLine();
int one = int.Parse(input1);

string input2 = Console.ReadLine();
int two = int.Parse(input2);

float sum = (float)one / two;


Console.WriteLine($"{sum}");