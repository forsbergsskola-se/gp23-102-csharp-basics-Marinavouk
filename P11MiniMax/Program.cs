// See https://aka.ms/new-console-template for more information



int input1 = int.Parse(Console.ReadLine());
int input2 = int.Parse(Console.ReadLine());
int input3 = int.Parse(Console.ReadLine());

if (input1 < input2 && input1 < input3)
{
    Console.WriteLine("The minimum is: " + input1);
}
else if (input2 < input1 && input2 < input3)
{
    Console.WriteLine("The minimum is: " + input2);
}
else  if (input3 < input1 && input3 < input2)
{
    Console.WriteLine("The minimum is: " + input3);
}

if (input1 > input2 && input1 > input3)
{
    Console.WriteLine("The maximum is: " + input1);
}

else if (input2 > input1 && input2 > input3)
{
    Console.WriteLine("The maximum is: " + input2);
}

else if(input3 > input1 && input3 > input2)
{
     Console.WriteLine("The maximum is: " + input3);
}



