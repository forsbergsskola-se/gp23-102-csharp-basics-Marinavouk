Console.WriteLine("Welcome to Nim!");
Console.WriteLine("|||||||||||||||||||||||| (24)");
int totalMatches = 24;

matches:
Console.WriteLine("How many matches do you want to draw?");
int userInput = int.Parse(Console.ReadLine());

// if not right amount: show error then go to matches
if (userInput <= 0 || userInput >= 4)
{
    Console.WriteLine("Invalid input, try again");
    goto matches;
}

totalMatches -= userInput;
Console.WriteLine("Draw matches here later: " + totalMatches);
// if no match left: show lose and go to game over
if (totalMatches == 0 || totalMatches < 0)
{
    Console.WriteLine("You lose");
    goto GameOver;
}


int aiChoice = Random.Shared.Next(1, 4);

totalMatches -= aiChoice;
Console.WriteLine(totalMatches);
// if no match left: show win (lose for ai) and go to game over
if (totalMatches == 0)
{
    Console.WriteLine("You won");
    goto GameOver;
}
goto matches;



GameOver:;