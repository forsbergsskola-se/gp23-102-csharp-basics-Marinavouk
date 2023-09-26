// See https://aka.ms/new-console-template for more information

Console.WriteLine("Give me a number of seconds");
string number = Console.ReadLine();
float input = float.Parse(number);
float day = input / (60 * 60 * 24) ;

int s = (int)(input % 60);
int m = (int)((input / 60) % 60);
int tim = (int)((input / (60 * 60)) % 24);
int d = (int)(day);

Console.WriteLine($"Seconds: {s}");
Console.WriteLine($"Minutes: {m}");
Console.WriteLine($"Hours: {tim}");
Console.WriteLine($"Days: {d}");
Console.WriteLine($"{d}. {tim} : {m} : {s} ");
Console.WriteLine($"In total, that's {day}");