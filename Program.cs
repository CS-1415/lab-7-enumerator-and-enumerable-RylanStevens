using System;
class Program
{
    static void Main()
    {
        var list = new DoublyLinkedList<int>();
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1 - Add an item to the beginning of the list");
            Console.WriteLine("2 - Add an item to the end of the list");
            Console.WriteLine("3 - Print the list contents");
            Console.WriteLine("4 - Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter a value to add at the beginning: ");
                    if (int.TryParse(Console.ReadLine(), out int firstValue))
                    {
                        list.AddFirst(firstValue);
                        Console.WriteLine($"Added {firstValue} to the beginning.");
                    }
                    break;
                case "2":
                    Console.Write("Enter a value to add at the end: ");
                    if (int.TryParse(Console.ReadLine(), out int lastValue))
                    {
                        list.AddLast(lastValue);
                        Console.WriteLine($"Added {lastValue} to the end.");
                    }
                    break;
                case "3":
                    Console.WriteLine("List contents:");
                    foreach (var value in list)
                    {
                        Console.Write($"{Value} ");
                    }
                    Console.WriteLine();
                    break;
                case "4":
                    exit = true;
                    Console.WriteLine("Exiting program.");
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}