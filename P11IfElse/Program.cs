// See https://aka.ms/new-console-template for more information


Console.WriteLine("What's your age?");
string ageInput = Console.ReadLine();
int age = int.Parse(ageInput);

if (age <= 12)
{
            Console.WriteLine("You are a child");
}
else if (age > 12 && age < 19)
{
            Console.WriteLine("You are a teenagers");
}
else
{
            Console.WriteLine("You are a grown-up");
}

Console.WriteLine("Give me another integer.");
string secondInput = Console.ReadLine();
int secondNumber = int.Parse(secondInput);

if (secondNumber < age)
{
            Console.WriteLine($"The maximum is: {age}");
}

else
{
            Console.WriteLine($"The maximum is: {secondNumber}");
}

if ( age % 2 == 0)
{
            Console.WriteLine("The code is even");
          
}

else
{
Console.WriteLine("The number is odd");
}



