using ATMApp.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMApp.App
{
    class Entry
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();
            long cardNumber = Validation.Convert<long>("Y our card number");
            Console.WriteLine($"Your card number is {cardNumber}");

            Utility.PressEnterToContinue();
        }
    }
}