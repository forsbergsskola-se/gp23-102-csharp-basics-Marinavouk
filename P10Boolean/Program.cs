// See https://aka.ms/new-console-template for more information

using System.Runtime.Versioning;

Console.WriteLine("What's your age?");
string ageInput = Console.ReadLine();
int age = int.Parse(ageInput);
bool isChild = true;
bool isTeenager = true;
bool isGrownup = true;

isChild = age <= 12;
isTeenager = age < 19;
isGrownup = age >= 19;

Console.WriteLine($"You are a child: {isChild}");
Console.WriteLine($"You are a teenager: {isTeenager}");
Console.WriteLine($"You are a grown-up: {isGrownup}");


