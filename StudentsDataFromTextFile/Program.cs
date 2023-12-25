using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDataFromTextFile
{
    public class Program
    {
        static void filess()
        {
            string path = "C:\\Users\\dell\\source\\repos\\Console_codes\\studentData.txt";
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string[] line = sr.ReadToEnd().Split('\n');
                    foreach (string x in line)
                    {
                        Console.WriteLine(x);
                    }
                }
            }
            else
            {
                Console.WriteLine("File not found soo we create file in same path and enter student details\n\nStudent Details");
                using (StreamWriter sr = new StreamWriter(path))
                {
                    sr.WriteLine("Student_Roll  : 1");
                    sr.WriteLine("Student_Name  : Naga Suresh Reddy");
                    sr.WriteLine("stuent_address: Hydrabad");
                    sr.Close();
                }

                using (StreamReader sr2 = new StreamReader(path))
                {
                    String[] s2 = sr2.ReadToEnd().Split('\n');
                    foreach (String x in s2)
                    {
                        Console.WriteLine(x);
                    }
                    sr2.Close();
                }
            }
        }
        static void Main(string[] args)
        {   
            filess();
        }
    }
}
