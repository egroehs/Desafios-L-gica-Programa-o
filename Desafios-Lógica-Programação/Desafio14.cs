using System;
using System.Linq;

class Desafio14
{
    int[] NumbersArray;

    public Desafio14(int[] numbersArray)
    {
        this.NumbersArray = numbersArray;
    }

    public void StartMenu()
    {
        string option;
        do
        {
            Console.WriteLine("==== MENU OPTIONS ====");
            Console.WriteLine("1 - Add a new number to the end of the array");
            Console.WriteLine("2 - Remove a number by its position");
            Console.WriteLine("3 - Remove number(s) by value");
            Console.WriteLine("4 - Sort numbers in ascending order");
            Console.WriteLine("5 - Sort numbers in descending order");
            Console.WriteLine("6 - Sum all values in the array");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("======================");
            Console.Write("Choose an option: ");
            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Enter the number to add: ");
                    AddNumberToArray();
                    break;

                case "2":
                    Console.Write("Enter the position to remove: ");
                    RemoveNumberWithIndex();
                    break;

                case "3":
                    Console.Write("Enter the value to remove: ");
                    RemoveNumber();
                    break;

                case "4":
                    OrderAsc();
                    break;

                case "5":
                    OrderDesc();
                    break;

                case "6":
                    SumValues();
                    break;

                case "0":
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Console.WriteLine("Current array: " + string.Join(", ", NumbersArray));
            Console.WriteLine();

        } while (option != "0");
    }

    protected void AddNumberToArray()
    {
        if (int.TryParse(Console.ReadLine(), out int newNumber))
        {
            Array.Resize(ref NumbersArray, NumbersArray.Length + 1);
            NumbersArray[NumbersArray.Length - 1] = newNumber;
            Console.WriteLine("Number added.");
        }
        else
        {
            Console.WriteLine("Invalid number.");
        }
    }

   protected void RemoveNumberWithIndex()
    {
        if (int.TryParse(Console.ReadLine(), out int pos) && pos >= 0 && pos < NumbersArray.Length)
        {
            NumbersArray = NumbersArray.Where((val, index) => index != pos).ToArray();
            Console.WriteLine("Number removed.");
        }
        else
        {
            Console.WriteLine("Invalid position.");
        }
    }

   protected void RemoveNumber()
    {
        if (int.TryParse(Console.ReadLine(), out int valToRemove))
        {
            NumbersArray = NumbersArray.Where(n => n != valToRemove).ToArray();
            Console.WriteLine("All occurrences removed.");
        }
        else
        {
            Console.WriteLine("Invalid value.");
        }
    }

    protected void OrderAsc()
    {
        Array.Sort(NumbersArray);
        Console.WriteLine("Array sorted in ascending order.");
    }

    protected void OrderDesc()
    {
        Array.Sort(NumbersArray);
        Array.Reverse(NumbersArray);
        Console.WriteLine("Array sorted in descending order.");
    }

    protected void SumValues()
    {
        int sum = NumbersArray.Sum();
        Console.WriteLine($"The sum of all values is: {sum}");
    }
}
