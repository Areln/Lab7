using System;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            string runAgain = "y";
            while (runAgain != "n")
            {
                string consoleInput = Console.ReadLine();
                if (ValidateName(consoleInput))
                {
                    Console.WriteLine("Name Validated");
                }
                else if (ValidateEmailAddr(consoleInput))
                {
                    Console.WriteLine("Email Validated");
                }
                else if (ValidateCellNumber(consoleInput))
                {
                    Console.WriteLine("Phone Number Validated");
                }
                else if (ValidateDate(consoleInput))
                {
                    Console.WriteLine("Date Validated");
                }
                else if (ValidateHTMLElement(consoleInput))
                {
                    Console.WriteLine("HTML Element Validated");
                }
                else
                {
                    Console.WriteLine($"{consoleInput} did not validate to anything");
                }
            }
        }
        static bool ValidateDate(string dateInput)
        {
            if (Regex.IsMatch(dateInput, @"[0-9]{2}\/[0-9]{2}\/[0-9]{4}$"))
            {
                return true;
            }
            return false;
        }
        static bool ValidateCellNumber(string numberInput)
        {
            if (Regex.IsMatch(numberInput, @"[0-9]{3}-[0-9]{3}-[0-9]{4}$"))
            {
                return true;
            }
            return false;
        }
        static bool ValidateName(string nameInput)
        {
            if (Regex.IsMatch(nameInput, @"(^[A-Z])[a-z]{1,30}$"))
            {
                return true;
            }
            return false;
        }
        static bool ValidateEmailAddr(string emailInput)
        {
            if (Regex.IsMatch(emailInput, @"[a-zA-Z0-9]{5,30}@[A-Za-z]{5,10}\.[A-Za-z]{2,3}$"))
            {
                return true;
            }
            return false;
        }
        static bool ValidateHTMLElement(string elementTagInput) 
        {
            if (Regex.IsMatch(elementTagInput, @"^<[A-Za-z]+> ?<[A-Za-z]+\/>$"))
            {
                return true;
            }
            return false;
        }
    }
}
