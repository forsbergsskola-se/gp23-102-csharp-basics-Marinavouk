// See https://aka.ms/new-console-template for more information

 var one = (byte)Random.Shared.Next();
 var two = (byte)Random.Shared.Next();
 var three = (byte)Random.Shared.Next();
 var four = (byte)Random.Shared.Next();
 var five = (byte)Random.Shared.Next();
 var six = (byte)Random.Shared.Next();
 var  x = System.Text.Encoding.ASCII.GetChars(new byte[]{one, two, three, four, five, six});
 Console.WriteLine();