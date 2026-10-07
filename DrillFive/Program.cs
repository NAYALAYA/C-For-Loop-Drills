using System;

class Program
{
    static void Main()
    {
        string original = "DotNet";
        string reversed = "";

        
        for (int i = original.Length -1; i >= 0; i--)
        {
            // TODO: Write a for loop that starts at the last index (original.Length - 1) 
            // and counts down to 0, appending each character to 'reversed'.
            reversed += original[i];
        }
        Console.WriteLine($"Reversed: {reversed}");
    }
}

