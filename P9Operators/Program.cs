// See https://aka.ms/new-console-template for more information

Console.WriteLine("Give me a number of seconds");
string number = Console.ReadLine();
float input = float.Parse(number);
float tim = input * 60 * 60;
float d = tim / 24;
float h = tim % 24;
float m = h % 60;
float s = m % 60;
  

Console.WriteLine($"Seconds: {s}");
Console.WriteLine($"Minutes: {m}");
Console.WriteLine($"Hours: {h}");
Console.WriteLine($"Days: {d}");
Console.WriteLine($"{d}. {h} : {m} : {s} ");