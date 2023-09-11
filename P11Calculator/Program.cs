// See https://aka.ms/new-console-template for more information

int input1 = int.Parse(Console.ReadLine());
string chr = Console.ReadLine();
int input2 = int.Parse(Console.ReadLine());

if (chr  =="-")
{
    Console.WriteLine(input1 - input2);
}
else if (chr == "+")
{
    Console.WriteLine(input1 + input2);
}
else if (chr == "*")
{
    Console.WriteLine(input1 * input2);
}

else
{
    Console.WriteLine(input1 / input2);
}

