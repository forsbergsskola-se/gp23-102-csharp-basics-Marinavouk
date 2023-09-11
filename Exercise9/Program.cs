// See https://aka.ms/new-console-template for more information
//Write a program that takes an integer input representing seconds and
//converts it to minutes and remaining seconds, then displays the result.

Console.Write("Type seconds");
string sec = Console.ReadLine();

int seconds = int.Parse(sec); 
int minutes = seconds / 60 ;

float rest = seconds % 60;  


Console.WriteLine($"Minutes: {minutes} Seconsd: {rest}" );



