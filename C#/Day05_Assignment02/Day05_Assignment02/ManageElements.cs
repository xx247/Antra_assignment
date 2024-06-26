using System;

namespace Day05_Assignment02;

public static class ManageElements
{
    public static void Manage()
    {
        List<string> itemList = new List<string>();
        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
            string input = Console.ReadLine();

            if (input == "--")
            {
                // Clear list
                itemList.Clear();
                Console.WriteLine("List cleared.");
            }
            else if (input.StartsWith("+"))
            {
                // Add item
                string itemToAdd = input.Substring(1).Trim();
                if (!string.IsNullOrEmpty(itemToAdd))
                {
                    itemList.Add(itemToAdd);
                    Console.WriteLine($"Added: {itemToAdd}");
                }
            }
            else if (input.StartsWith("-"))
            {
                // Remove item
                string itemToRemove = input.Substring(1).Trim();
                if (!string.IsNullOrEmpty(itemToRemove) && itemList.Remove(itemToRemove))
                {
                    Console.WriteLine($"Removed: {itemToRemove}");
                }
                else
                {
                    Console.WriteLine($"Item not found: {itemToRemove}");
                }
            }
            
            else
            {
                Console.WriteLine("Invalid command. Please try again.");
            }

            // Display current list
            Console.WriteLine("Current list:");
            if (itemList.Count == 0)
            {
                Console.WriteLine("The list is empty.");
            }
            else
            {
                foreach (string item in itemList)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
