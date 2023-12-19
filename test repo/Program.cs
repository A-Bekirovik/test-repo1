// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("hello eartt");
var i = 0;

while (true) 
{
    i += 2;
    Console.WriteLine("tink...");
    if (i == 4)
    {
        Console.WriteLine("poop");
    } else if (i == 6)
	{
        i = 0;
        Console.Clear();
        i = 0;
    }
    Thread.Sleep(1000);
}
