using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    internal static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
         static void  Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TaskManager());

           /* string path = @"C:\Users\Arseniy\Desktop\ManagerApp\Data\data.txt";
            FileInfo file = new FileInfo(path);
            int TotalNum;
            List<string> Temp = new List<string>();
            List<SomeTask> ArrTask = new List<SomeTask>();

            if (file.Exists) 
            {
                TotalNum = 0;
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != "#"|| (line = sr.ReadLine()) != null)
                    {
                        TotalNum= Convert.ToInt32(line);
                    }
                    while ((line = sr.ReadLine()) != null)
                    {
                        Temp.Add(line);
                    }
                   //сначала мы открыли файл и из него получили список строк
                }
                string[] Temp2 = new string[Temp.Count]; //затем превращаю список в массив без лишней инфы
                for (int i = 1; i < Temp.Count; i++) {
                    Temp2[i-1] = Temp[i];
                }
                //дальше надо просто из массива достать все и отобразить
            
            }
            if (!file.Exists)
            {
                TotalNum = 0;
                file.Create();
            }

            void DataReading() { 

            
            }   */
        } 

        
    }
        

}
