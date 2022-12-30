using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using hotelwithforms.BL;

namespace hotelwithforms.DL
{
    class workerDL
    {
        public static List<worker> workerlist = new List<worker>();
        public static List<worker> workerlistwithproduct = new List<worker>();

        public static void addworkerintolist(worker w)
        {
            workerlist.Add(w);
        }
        // function for sorting of workerdata
        public static void sorting()
        {
            workerlist = workerlist.OrderBy(o => o.Workerage).ToList();
        }
        public static void addinfile(worker w)
        {
            string workersinformation = "workers information.txt";
            StreamWriter f = new StreamWriter(workersinformation,true);
            f.WriteLine(w.Workername + "," + w.Workersalary + "," + w.Workerage + "," + w.Workerexperience);
            f.Flush();
            f.Close();
        }
        public static void addalllistatonceintifile()
        {
            string workersinformation = "workers information.txt";
            StreamWriter f = new StreamWriter(workersinformation);
            foreach (worker w in workerlist)
            {
                f.WriteLine(w.Workername + "," + w.Workersalary + "," + w.Workerage + "," + w.Workerexperience);
            }
            f.Flush();
            f.Close();
        }
        // function for loading worker data from the file
        public static bool readFromFile()
        {
            string path= "workers information.txt";
            string record;
            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string workername = splittedRecord[0];
                    double workersalary = double.Parse(splittedRecord[1]);
                    int workerage = int.Parse(splittedRecord[2]);
                    string experience = splittedRecord[3];
                    worker w = new worker(workername,workersalary,workerage, experience);
                    workerlist.Add(w);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void deleteWorker(int index)
        {
            workerlist.RemoveAt(index);
        }

    }
}

