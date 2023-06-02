using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        // Step 1: Read pairs from "phones.txt" into PhoneBook and write only PhoneNumbers into "Phones.txt"
        ReadPhoneBookFromFile(phoneBook, "phones.txt");
        WritePhoneNumbersToFile(phoneBook, "Phones.txt");

        // Step 2: Find and print phone number by the given name
        Console.WriteLine("Enter a person's name to find their phone number:");
        string name = Console.ReadLine();
        string phoneNumber = FindPhoneNumberByName(phoneBook, name);
        if (phoneNumber != null)
            Console.WriteLine($"Phone number for {name}: {phoneNumber}");
        else
            Console.WriteLine("No phone number found for the given name.");

        // Step 3: Change phone numbers in the format 80######### to new format +380#########
        Dictionary<string, string> updatedPhoneBook = ChangePhoneNumberFormat(phoneBook);
        WritePhoneBookToFile(updatedPhoneBook, "New.txt");
    }

    static void ReadPhoneBookFromFile(Dictionary<string, string> phoneBook, string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(':');
            if (parts.Length == 2)
            {
                string name = parts[0].Trim();
                string phoneNumber = parts[1].Trim();
                phoneBook[name] = phoneNumber;
            }
        }
    }

    static void WritePhoneNumbersToFile(Dictionary<string, string> phoneBook, string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (string phoneNumber in phoneBook.Values)
            {
                writer.WriteLine(phoneNumber);
            }
        }
    }

    static string FindPhoneNumberByName(Dictionary<string, string> phoneBook, string name)
    {
        if (phoneBook.ContainsKey(name))
            return phoneBook[name];
        else
            return null;
    }

    static Dictionary<string, string> ChangePhoneNumberFormat(Dictionary<string, string> phoneBook)
    {
        Dictionary<string, string> updatedPhoneBook = new Dictionary<string, string>();
        foreach (var entry in phoneBook)
        {
            string name = entry.Key;
            string phoneNumber = entry.Value;

            if (phoneNumber.StartsWith("80") && phoneNumber.Length == 11)
            {
                phoneNumber = "+380" + phoneNumber.Substring(2);
            }

            updatedPhoneBook[name] = phoneNumber;
        }
        return updatedPhoneBook;
    }

    static void WritePhoneBookToFile(Dictionary<string, string> phoneBook, string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in phoneBook)
            {
                string name = entry.Key;
                string phoneNumber = entry.Value;
                writer.WriteLine($"{name}: {phoneNumber}");
            }
        }
    }
}