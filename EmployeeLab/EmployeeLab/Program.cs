using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLab
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFile();
            bool keepLooping = true;
            while(keepLooping)
            {
                DisplayMenu();
                string userInput = GetInput();
                switch (userInput)
                {
                    case "1":
                        CreateNewEmployee();
                        break;
                    case "2":
                        TerminateEmployee();
                        break;
                    case "3":
                        GiveEmployeeRaise();
                        break;
                    case "4":
                        PayAllEmployees();
                        break;
                    case "5":
                        DisplayAllEmployees();
                        break;
                    case "6":
                        keepLooping = false;
                        break;
                    default:
                        break;
                }
            }
        }

        public static void ReadFile()
        {

        }

        public static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Option?");
        }

        public static string GetInput()
        {
            return Console.ReadLine();
        }

        public static void CreateNewEmployee()
        {

        }

        public static void TerminateEmployee()
        {

        }

        public static void GiveEmployeeRaise()
        {

        }

        public static void PayAllEmployees()
        {

        }

        public static void DisplayAllEmployees()
        {

        }

    }
}
