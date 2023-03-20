using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleTaskManager
{
    internal class Storage
    {
        const string StorageName = "textdata.txt";
        StreamWriter f = new StreamWriter("testdata.txt");
        public static void Save()
        {
            StreamWriter f = new StreamWriter(StorageName);
            foreach(Task task in Model.Table)
            {
                f.Write("►");
                f.Write(task.Number.ToString());
                f.Write("◘");
                f.Write(task.Name.ToString());
                f.Write("◘");
                f.Write(task.Description.ToString());
                f.Write("◘");
                f.Write(task.DateOfCreation.ToString());
                f.Write("◘");
                f.Write(task.DateOfCompletion.ToString());
                f.Write("◘");
                f.Write(task.LevelOfDificulty.ToString());
                f.Write("◘");
                f.Write(task.State.ToString());
                f.WriteLine();
            }
            f.Close();
        }
        
        public static void Load()
        {
            //StreamWriter f = new StreamWriter(StorageName);
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader(StorageName))
                {
                    // Read the stream as a string, and write the string to the console.
                    stringBuilder.Append(sr.ReadToEnd());
                }
                ReadFileData(stringBuilder.ToString().Split('►'));
            }
            catch
            {
                File.Create(StorageName);
            }
        }

        public static void ReadFileData(string[] inputLines)
        {
            int num=0;
            string name=String.Empty;
            string description = String.Empty;
            DateTime creation = DateTime.Now;
            DateTime completion = DateTime.Now;
            Dificulty dif = (Dificulty)1; ;
            bool state = false;

            int i = 0;
            StringBuilder temp= new StringBuilder();
            foreach (string line in inputLines)
            {
                foreach(var c in line)
                {
                    if (c.Equals('◘'))
                    {
                        switch (i)
                        {
                            case 0:
                                num = int.Parse(temp.ToString());
                                break;
                            case 1:
                                name = temp.ToString();
                                break;
                            case 2:
                                description = temp.ToString();
                                break;
                            case 3:
                                var dateInput = temp.ToString().Split(' ', '.', ',');
                                creation = new DateTime(int.Parse(dateInput[2]), int.Parse(dateInput[1]), int.Parse(dateInput[0]));
                                break;
                            case 4:
                                var dateInpu = temp.ToString().Split(' ', '.', ',');
                                completion = new DateTime(int.Parse(dateInpu[2]), int.Parse(dateInpu[1]), int.Parse(dateInpu[0]));
                                break;
                            case 5:
                                if (temp.ToString() == "Easy")
                                    dif = Dificulty.Easy;
                                if (temp.ToString() == "Normal")
                                    dif = Dificulty.Normal;
                                if (temp.ToString() == "Hard")
                                    dif = Dificulty.Hard;
                                if (temp.ToString() == "Impossible")
                                    dif = Dificulty.Impossible;
                                else
                                    dif = Dificulty.Easy;
                                break;
                            case 6:
                                if (temp.ToString() == "true")
                                    state = true;
                                else
                                    state = false;
                                break;
                        }
                        i++;
                        temp.Clear();
                    }
                    else if (c.Equals('\n'))
                    {
                        Model.Table.Add(new Task(num,name,description,creation,completion,dif,state));
                        i = 0;
                        temp.Clear();
                    }
                    else
                    {
                        temp.Append(c);
                    }
                    
                }
            }

            
        }

    }
}
