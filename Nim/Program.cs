// See https://aka.ms/new-console-template for more information


using System.ComponentModel.Design;

Console.WriteLine("Welcome to Nim!");
Console.WriteLine("|||||||||||||||||||||||| (24)");
int totalMatches = 24;

matches:
if (totalMatches == 0)
{
    Console.WriteLine("You won");
}
else
{


    Console.WriteLine("How many matches do you want to draw?");
    int userInput = int.Parse(Console.ReadLine());

// if not right amount: show error then go to matches
    if (userInput > 0 && userInput < 4)
    {
        if (totalMatches >= 0 && totalMatches <= 24)
        {

            int leftMatches = totalMatches - userInput;
            Console.WriteLine("Draw matches here later: " + leftMatches);
            totalMatches -= userInput;

            int aiChoice = 1;
            int aiMatches = totalMatches - aiChoice;
            Console.WriteLine(aiMatches);
            totalMatches -= aiChoice;
            goto matches;
        }


        else
        {
            Console.WriteLine("Game Over");
        }





















    }
    else
    {
        Console.WriteLine("Invalid input, try again");
        goto matches;
    }

    Console.WriteLine("You lost");
}

