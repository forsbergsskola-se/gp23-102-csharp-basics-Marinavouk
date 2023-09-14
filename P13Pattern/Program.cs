// See https://aka.ms/new-console-template for more information

int userInput = int.Parse(Console.ReadLine());
string pattern = "#-#-#-#-#-";
int count = 0;
patternp13:
if (count < userInput)
{
    count += 1;
    Console.WriteLine(pattern);
    goto patternp13;
}