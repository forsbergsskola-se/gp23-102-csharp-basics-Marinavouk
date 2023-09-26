// See https://aka.ms/new-console-template for more information

using Microsoft.Win32.SafeHandles;

int userInput = int.Parse(Console.ReadLine());
int count = 0;
int innerCount = 0;
string dash = "#";
triangle:
if (count < userInput)
{
     inneTriangle:
     if (innerCount < userInput)
     {
         Console.Write(dash);
         innerCount ++;
         goto inneTriangle;
    
     }
     count = innerCount;
     count++;
     Console.WriteLine(dash);
     goto triangle;
     
}
 


