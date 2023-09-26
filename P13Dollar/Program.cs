
using System.Runtime.InteropServices;

Console.Write("How many dollars do you want to print?");
int numberInput = int.Parse(Console.ReadLine());

string dollar = "$";
int count = 0;

dollars:
if (count < numberInput)
{
    Console.Write( dollar);
    count++;
    goto dollars;
}
