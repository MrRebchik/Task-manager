using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTaskManager
{
    internal static class Comand
    {
        static public void Recognize()
        {
            Console.WriteLine("Привет!");
            while (true)
            {
                Console.WriteLine("Введите команду");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "save":
                        Storage.Save();
                        Console.WriteLine("Данные сохранены");
                        break;
                    case "help":
                        Console.WriteLine("Перечень доступных команд: help, show, add, open, edit, save, exit");
                        break;
                    case "show":
                        Model.Show();
                        break;
                    case "exit":
                        Console.WriteLine("Закрытие программы");
                        break;
                    case "add":
                        Model.Add();
                        break;
                    case "open":
                        Model.Open();
                        break;
                    case "edit":
                        Model.Edit();
                        Console.WriteLine("Задание отредактировано");
                        break;
                    default:
                        Console.WriteLine("неизвестная команда, попробуйте help");
                        break;
                }
                if (input == "exit")
                {
                    Storage.Save();
                    Environment.Exit(0);
                }
            }

        }
    }
}
