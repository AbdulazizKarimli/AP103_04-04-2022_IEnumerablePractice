using Homework.Models;
using System;
using System.Collections.Generic;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("test user");

            bool check = true;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Share status");
                Console.WriteLine("2. Get all statuses");
                Console.WriteLine("3. Get status by id");
                Console.WriteLine("4. Filter status by date ");
                Console.WriteLine("0. Quit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("title:");
                        string title = Console.ReadLine();
                        Console.WriteLine("content:");
                        string content = Console.ReadLine();

                        Status status = new Status(title, content);

                        user.ShareStatus(status);
                        break;
                    case "2":
                        foreach (var item in user.GetAllStatuses())
                        {
                            Console.WriteLine(item.GetStatusInfo());
                        }
                        break;
                    case "3":
                        Console.WriteLine("Id:");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(user.GetStatusById(id).GetStatusInfo());
                        break;
                    case "4":

                        foreach (var item in user.FilterStatusByDate(DateTime.Now.AddSeconds(5)))
                        {
                            Console.WriteLine(item.GetStatusInfo());
                        }
                        break;
                    case "0":
                        check = false;
                        break;
                    default:
                        Console.WriteLine("wrong input!!!");
                        break;
                }
            } while (check);


        }
    }
}
