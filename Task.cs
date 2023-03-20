using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTaskManager
{
    public enum Dificulty
    {
        Easy = 1,
        Normal = 2,
        Hard = 3,
        Impossible = 4
    }
    public class Task
    {
        public int Number { get; }
        public string Name { get; }
        public string Description { get; }
        public DateTime DateOfCreation = DateTime.Now;
        public DateTime DateOfCompletion { get; }
        public Dificulty LevelOfDificulty { get; }
        public bool State { get; }


        public Task(int numb, string name, string description, DateTime date, Dificulty dif, bool state)
        {
            Number = numb;
            Name = name;
            Description = description;
            DateOfCompletion = date;
            LevelOfDificulty = dif;
            State = state;
        }

        public Task(int numb, string name, string description, DateTime date, Dificulty dif)
        {
            Number = numb;
            Name = name;
            Description = description;
            DateOfCompletion = date;
            LevelOfDificulty = dif;
            State = false;
        }

        public Task(int numb, string name, string description, DateTime create, DateTime date, Dificulty dif,bool stetr)
        {
            Number = numb;
            Name = name;
            Description = description;
            DateOfCreation = create;
            DateOfCompletion = date;
            LevelOfDificulty = dif;
            State = stetr;
        }


    }
}
