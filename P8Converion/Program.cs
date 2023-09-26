// See https://aka.ms/new-console-template for more information

Console.WriteLine("Give me a number");
string number = Console.ReadLine();
double d = Convert.ToDouble(number); //double.Parse(number)
Console.WriteLine(d);
int i = (int)d;
Console.WriteLine(i);
int o = int.Parse(number);
Console.WriteLine(o);

