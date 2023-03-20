using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    static class DataBank
    {
        public static  int TotalNum = 0;
        public static string TempText = "0";
        public static List<SomeTask> ArrTask = new List<SomeTask>();
        public static bool Check = false;
        public static Dictionary<int, string> Task = new Dictionary<int, string>();
        public enum Dificulty
            {
                Elementary,
                Easy,
                Medium,
                Hard,
                IncrediblyDifficult,
            }
        public class SomeTask
        {
            int NumberOfRaw;
            string CertainTask;
            DateTime TimeOfCreation = new DateTime();
            //DateTime.Now во время создания нового экзамепляра
            
            Dificulty dificulty;
            bool Ready;
            public SomeTask(int numb)
            {
                NumberOfRaw = numb;
                CertainTask = TempText;
                TimeOfCreation = DateTime.Now;
            }

        }
    }
}
