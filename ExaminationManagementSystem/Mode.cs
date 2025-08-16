using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;


namespace ExaminationManagementSystem
{
    public class Mode
    {
        public static void Welcome()
        {

            Console.WriteLine("Welcome to the Examination Management System");
            Console.WriteLine("----------------------------------------------");
            Console.Write($"Select from next choices" +
                $"\n -1- Teacher Mode" +
                $"\n -2- Student Mode" +
                $"\n---> ");

            string choice;
            do
            {
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": // Teacher Mode
                        Console.WriteLine("You selected Teacher Mode\nPress Enter To continue");
                        Console.ReadLine();
                        Teacher teacher = new Teacher();
                       


                        break;

                    case "2": // Student Mode
                        Console.WriteLine("You selected Student Mode\nPress Enter To continue");
                        Console.ReadLine();
                        Student student = new Student();


                        break;
                    default:
                        Console.WriteLine("Invalid choice, please chose (1) or (2) only");
                        Console.Write("\n---> ");
                        break;
                }
            }
            while (choice != "1" && choice != "2");

        }
    }
}