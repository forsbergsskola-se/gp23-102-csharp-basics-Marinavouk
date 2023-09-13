// See https://aka.ms/new-console-template for more information


using System.ComponentModel.Design;

Console.WriteLine("Welcome to Nim!");
Console.WriteLine("|||||||||||||||||||||||| (24)");
int totalMatches = 24;

matches:
Console.WriteLine("How many matches do you want to draw?");
int userInput = int.Parse(Console.ReadLine());

if (totalMatches >=0 && totalMatches <= 24)
{
    
    int matchesLeft = totalMatches - userInput;
    Console.WriteLine("Draw matches here later: " + matchesLeft);
    totalMatches -= userInput;
   
    int aiChoice = 1;
    int matchesChoice = totalMatches - aiChoice;
    Console.WriteLine(matchesChoice);
    totalMatches -= aiChoice;
    
    
        goto matches;
        
}

else
{
    Console.WriteLine("Game Over");
}
