using System;

class Program
{
    static void Main()
    {
        string[] fruits = { "Apple", "Banana", "Cherry", "Dragonfruit" };

        // TODO: Set the condition to stop before reaching the length of the array
        for (int i = 0; i < fruits.Length; i++)
        {
            // TODO: Print the current index and fruit name
            // Example output: "Index 0: Apple"
            Console.WriteLine("Index " + i + ": " + fruits[i]);
        }
    }
}
