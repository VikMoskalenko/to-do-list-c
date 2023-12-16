using System;
using System.Collections.Concurrent;
using System.Collections.Generic;


namespace to_do_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the to do list program");
            List<string> taskList = new List<string>();
            string option = "";

            while (option != "e")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter 1 to add rask to the list");
                Console.WriteLine("Enter 2 to remove task from the list");
                Console.WriteLine("Enter 3 to view the list");
                Console.WriteLine("Enter e to exit the program");

                option = Console.ReadLine();
                if (option == "1")
                {
                    Console.WriteLine("Please enter the name of the task to add");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("The task added to the list");
                }
                else if (option == "2")
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + " : " + taskList[i]);
                    }
                    Console.WriteLine("Please enter the number of the task to remove from the list");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(taskNumber);
                }
                else if (option == "3")
                {
                    Console.WriteLine("Current task in the list :");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(taskList[i]);
                    }

                }
                else if (option == "4")
                {
                    Console.WriteLine("Exit the program");
                }
                else
                {
                    Console.WriteLine("invalid option , try again");
                }
            }
            Console.WriteLine("Thank you for your time");
        }
    }
}
