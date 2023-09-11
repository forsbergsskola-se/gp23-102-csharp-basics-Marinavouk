// See https://aka.ms/new-console-template for more information

string inputSomething = Console.ReadLine();


if (char.IsNumber(Convert.ToChar(inputSomething)))

{
    Console.WriteLine("It's a digit.");
}

else if (inputSomething == "a" || inputSomething == "e" || inputSomething == "o" ||
    inputSomething == "i" || inputSomething == "u")
{
    Console.WriteLine("It's a vowel.");
}
else
{
    Console.WriteLine("It's a consonant.");
}




    


