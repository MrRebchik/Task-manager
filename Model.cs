using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTaskManager
{
    internal static class Model
    {
        static public List<Task> Table = new List<Task>();

        static public void Add()
        {
            Console.WriteLine("Введите название");
            string name = Console.ReadLine();
            Console.WriteLine("описание");
            string description = Console.ReadLine();
            Console.WriteLine("введите дату через пробелы: день месяц год");
            string[] dateInput = null;
            DateTime time=DateTime.Now;
            try
            {
                dateInput = Console.ReadLine().Split(' ','.',',');
                time = new DateTime(int.Parse(dateInput[2]), int.Parse(dateInput[1]), int.Parse(dateInput[0]));
            }
            catch
            {
                Console.WriteLine("Неправильный формат даты, установлена текущая");
                
            }
            Console.WriteLine("выбирите сложность: 1 - легко, 2 - нормально, 3 - сложно");
            Dificulty dificulty;
            try
            {
                dificulty = (Dificulty)int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Неправильный формат ввода");
                dificulty = (Dificulty)1;
            }
            Table.Add(new Task(Table.Count+1,name,description,time,dificulty,false));
            Console.Clear();
            Console.WriteLine("Задание добавлено.");
        }

        static public void Show()
        {
            {
                Console.Write("╔══════════");
                for (int i = 0; i < 4; i++)
                    Console.Write("╦══════════");
                Console.WriteLine("╗");
                Console.WriteLine("║   Номер  ║ Название ║Срок сдачи║Сложность ║Готовность║");
                if (Table.Count > 0)
                {
                    Console.Write("╠══════════");
                    for (int j = 0; j < 4; j++)
                        Console.Write("╬══════════");
                    Console.WriteLine("╣");
                }
            }
            for (int i = 0; i < Table.Count; i++)
            {
                string name = Table[i].Name;
                if (Table[i].Name.Length > 10) { name = name.Substring(0, 10); }
                Console.WriteLine
                    (
                    "║{0,-10}║{1,-10}║{2,-10}║{3,-10}║{4,-10}║",
                    Table[i].Number, 
                    name, 
                    Table[i].DateOfCompletion.ToString().Substring(0,10), 
                    Table[i].LevelOfDificulty, 
                    Table[i].State
                    );
                if(i != Table.Count - 1)
                {
                    Console.Write("╠══════════");
                    for (int j = 0; j < 4; j++)
                        Console.Write("╬══════════");
                    Console.WriteLine("╣");
                }
            }
            {
                Console.Write("╚══════════");
                for (int i = 0; i < 4; i++)
                    Console.Write("╩══════════");
                Console.WriteLine("╝");
            }
        }

        static public void Edit()
        {
            Console.WriteLine("Введите номер задания");
            int numberOfTask;
            try
            {
                numberOfTask = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Введен неверный номер задания");
                return;
            }
            int curentPosition = -1;
            for (int i = 0;i < Table.Count; i++)
            {
                if(Table[i].Number == numberOfTask)
                    curentPosition = i;
            }
            if(curentPosition < 0)
            {
                Console.WriteLine("Задание с данным номером не найдено");
                return;
            }
            Console.WriteLine("Какое поле вы хотите изменить:статус выполения, название, описание, сложность, дата сдачи?");
            string nameOfField = Console.ReadLine();
            switch (nameOfField)
            {
                case "статус выполнения":
                    bool state = !Table[curentPosition].State;
                    Table[curentPosition] = new Task
                        (
                        curentPosition + 1,
                        Table[curentPosition].Name,
                        Table[curentPosition].Description,
                        Table[curentPosition].DateOfCompletion,
                        Table[curentPosition].LevelOfDificulty,
                        state
                        );
                    break;
                case "название":
                    Console.WriteLine("Введите новое имя");
                    var newName = Console.ReadLine();
                    Table[curentPosition] = new Task
                        (
                        curentPosition + 1,
                        newName,
                        Table[curentPosition].Description,
                        Table[curentPosition].DateOfCompletion,
                        Table[curentPosition].LevelOfDificulty,
                        Table[curentPosition].State
                        );
                    break;
                case "описание":
                    Console.WriteLine("Введите новое описание");
                    var newDescription = Console.ReadLine();
                    Table[curentPosition] = new Task
                        (
                        curentPosition + 1,
                        Table[curentPosition].Name,
                        newDescription,
                        Table[curentPosition].DateOfCompletion,
                        Table[curentPosition].LevelOfDificulty,
                        Table[curentPosition].State
                        );
                    break;
                case "дата сдачи":
                    Console.WriteLine("Введите новую дату через пробелы: день месяц год");
                    string[] dateInput = Console.ReadLine().Split(' ');
                    DateTime newTime = new DateTime(int.Parse(dateInput[2]), int.Parse(dateInput[1]), int.Parse(dateInput[0]));
                    Table[curentPosition] = new Task
                        (
                        curentPosition + 1,
                        Table[curentPosition].Name,
                        Table[curentPosition].Description,
                        newTime,
                        Table[curentPosition].LevelOfDificulty,
                        Table[curentPosition].State
                        );
                    break;
                case "сложность":
                    Console.WriteLine("Выбирите новую сложность: 1 - легко, 2 - нормально, 3 - сложно");
                    Dificulty newDificulty = (Dificulty)int.Parse(Console.ReadLine());
                    Table[curentPosition] = new Task
                        (
                        curentPosition + 1,
                        Table[curentPosition].Name,
                        Table[curentPosition].Description,
                        Table[curentPosition].DateOfCompletion,
                        newDificulty,
                        Table[curentPosition].State
                        );
                    break;
                default:
                    Console.WriteLine("данного поля не существует");
                    return;
            }
            Console.Clear();
        }

        static public void Open()
        {
            Console.WriteLine("Введите номер задания");
            int numberOfTask;
            try
            {
                numberOfTask = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Введен неверный номер задания");
                return;
            }
            int curentPosition = -1;
            for (int i = 0; i < Table.Count; i++)
            {
                if (Table[i].Number == numberOfTask)
                    curentPosition = i;
            }
            if (curentPosition < 0)
            {
                Console.WriteLine("Задание с данным номером не найдено");
                return;
            }
            Console.Clear();
            Console.WriteLine(
                "Задание номер {0}:\n" +
                "\"{1}\"\n" +
                "Описание задания:{2}\n" +
                "Дата создания:{3}\n" +
                "К какому сроку нужно выполнить:{4}\n" +
                "Уровень сложности:{5}\n" +
                "Статус выполения:{6}\n", 
                Table[curentPosition].Number, 
                Table[curentPosition].Name,
                Table[curentPosition].Description,
                Table[curentPosition].DateOfCreation,
                Table[curentPosition].DateOfCompletion,
                Table[curentPosition].LevelOfDificulty,
                Table[curentPosition].State
                );
        }
    }

}
