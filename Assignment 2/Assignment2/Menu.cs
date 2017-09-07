using System;

namespace Assignment2
{
    class Menu
    {
        private static string aline = "--------------------------------------------------\n";
        public void Start()
        {
            Console.Clear();
            PrintBanner();
            PrintChoices();
            GetChoice();
            Console.ReadLine();
        }

        private string Banner ()
        {
            //string line   = "--------------------------------------------------\n";
            string header = "                MAIN MENU                         \n";
            return aline+header+aline;
        }

        private void PrintBanner()
        {
            Console.Write(Banner());
        }

        private string MenuItem (string text)
        {
            return "   " + text;
        }

        private void PC (string text)
        {
            Console.WriteLine(MenuItem(text));
        }


        private void PrintChoices ()
        {
            PC("Whole Numbers with For                : 1");
            PC("Floating Point Numbers with While     : 2");
            PC("Currency Converter with Do While loop : 3");
            PC("Work Shedule                          : 4");
            PC("Exit the program                      : 0");
            Console.Write(aline);
        }

        private string GetChoice()
        {
            Console.Write("Your choice: ");
            return Console.ReadLine();
        }

    }
}