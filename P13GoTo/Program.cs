// See https://aka.ms/new-console-template for more information
int numberOfTries = 0;
int noMoreTries = 10;

Console.WriteLine("I have picked a number from (0-100). It's your turn to guess it!");

Random myNumber = new Random();
int mN = myNumber.Next(0, 101);

tries:
int guessNumber = int.Parse(Console.ReadLine());

if (numberOfTries < noMoreTries && guessNumber != mN)
{
    if (guessNumber < mN)
    {
        Console.WriteLine("Ops, Try higher!");
        numberOfTries += 1;
        goto tries;

    }

    else
    {
        Console.WriteLine("Ops. Try lower!");
        numberOfTries += 1;
        goto tries;
    }
}

else if ( numberOfTries == noMoreTries)
{
    Console.WriteLine("Sorry, you lost!");
}

else
{
    Console.WriteLine("CONGRATS, YOU FOUND THE NUMBER!");
}
