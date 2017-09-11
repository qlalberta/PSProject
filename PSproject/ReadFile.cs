using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PSproject
{
    public class FileReader
    {
        public List<Staff> ReadFile()
        {
            public List<Staff> myStaff = new List<Staff>();
        string[] result = new string[2];
        string path = "staff.txt";
        string[] separator = { "," };
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.EndOfStream != true)
                    {

                        result = sr.ReadLine().Split(separator);
        Console.WriteLine(result[0], result[1]);
                        if (result[1] == "Manager")
                        {
                            Manager manager = new Manager();
    }
                        if (result[1] == "Admin")
                        {
                            myStaff.Add[result[0]];
                        }
sr.Close();
                    }
                }
            }
            else
            {
                Console.WriteLine("The file does not exist.");
            }
        }
    }

}
