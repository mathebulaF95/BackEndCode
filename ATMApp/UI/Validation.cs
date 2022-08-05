using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ATMApp.UI
{
    public static class Validation
    {
        public static T Convert<T>(string prompt)
        {
            bool valid = false;
            string userInput;

            while (!valid)
            {
                userInput = Utility.GetUserInput(prompt);

                try
                {
                    var convertor = TypeDescriptor.GetConverter(typeof(T));
                    if (convertor != null)
                    {
                        return (T)convertor.ConvertFromString(userInput);
                    }
                    else
                    {
                        return default;
                    }
                }
                catch
                {
                    Utility.PrintMassage("Invalid input. Try again.", false);
                }
            }
            return default;
        }
    }
}
