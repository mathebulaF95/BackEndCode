using System;
using System.Collections.Generic;
using System.Text;

namespace ATMApp.UI
{
    public static class AppScreen
    {
        internal static void Welcome()
        {
            //clear the console screen
            Console.Clear();
            //set the title of the console window
            Console.Title = "My ATM App";
            //set the text color
            Console.ForegroundColor = ConsoleColor.White;

            //set the welcome message
            Console.WriteLine("\n\n...............Welcome to My ATM App....................\n");
            //prompt the user to insert ATM card
            Console.WriteLine("Please insert your ATM card");

           Utility.PressEnterToContinue();
        }

     
    }
}
