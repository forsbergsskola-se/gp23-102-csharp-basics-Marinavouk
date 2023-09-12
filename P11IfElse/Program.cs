// See https://aka.ms/new-console-template for more information


Console.WriteLine("What's your age?");
string ageInput = Console.ReadLine();
int age = int.Parse(ageInput);

if (age <= 12) 
{
            Console.WriteLine("You are a child");
}
else if (age <= 19)
{
            Console.WriteLine("You are a teenager");
}
else
{
            Console.WriteLine("You are a grown-up");
}

Console.WriteLine("Give me another integer.");

int secondNumber = int.Parse(Console.ReadLine());
int max;
if (secondNumber > age)
{
    max = secondNumber;
    Console.WriteLine($"The  maximum is : {max}");
}
else
{
    max = age;
    Console.WriteLine($"The maximum is: {max}");
}
if ( max % 2 == 0)
{
    Console.WriteLine("The maximum of number is even");
}
else
{
    Console.WriteLine("The maximum of both numbers is odd");
}





