// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please pass me a seed(integer)");
int input1 = int.Parse(Console.ReadLine());
Console.WriteLine("Three integers between 0 and 5:");
Random random = new Random(input1);
Console.WriteLine(random.Next(0, 5));
Console.WriteLine(random.Next(0, 5));
Console.WriteLine(random.Next(0, 5));

Console.WriteLine("Three numbers between 0.0 and 0.5:");
Console.WriteLine(random.NextDouble() * 0.5);
Console.WriteLine(random.NextDouble() * 0.5);
Console.WriteLine(random.NextDouble() * 0.5);

Console.WriteLine("Three numbers between 0.2 and 0.7:");

Console.WriteLine(random.NextDouble() *(0.7 - 0.2) + 0.2);
Console.WriteLine(random.NextDouble() *(0.7 - 0.2) + 0.2);
Console.WriteLine(random.NextDouble() *(0.7 - 0.2) + 0.2);

Console.WriteLine("Give me a crit chance between 0,0 (0%) and 1,0 (100%)");
double critChance = double.Parse(Console.ReadLine());

if (Random.Shared.NextDouble() < critChance)
{
    Console.WriteLine("Crit");
}
else
{
    Console.WriteLine("No Crit");
}
Console.WriteLine(random.NextDouble() > critChance ? "Crit" : "No Crit");