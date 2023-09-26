// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your grades");

int grades = int.Parse(Console.ReadLine());

if (grades >= 90 && grades <= 100)
{
    Console.WriteLine("A");
}

else if (grades >= 80)
{
    Console.WriteLine("B");
}

else if (grades >= 70)
{
    Console.WriteLine("C");
}

else if (grades >= 60)
{
    Console.WriteLine("D");
}

else
{
    Console.WriteLine("F");
}