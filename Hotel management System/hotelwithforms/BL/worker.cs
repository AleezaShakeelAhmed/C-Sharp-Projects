using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelwithforms.BL
{
   public class worker
   {
        private string workername;
        private int workerage;
        private double workersalary;
        private string workerexperience;

        public string Workername { get => workername; set => workername = value; }
        public int Workerage { get => workerage; set => workerage = value; }
        public string Workerexperience { get => workerexperience; set => workerexperience = value; }
        public double Workersalary { get => workersalary; set => workersalary = value; }
        public worker(string workername, double workersalary,int workerage, string workerexperience)
        {
            this.Workername = workername;
            this.Workerage = workerage;
            this.Workersalary = workersalary;
            this.Workerexperience = workerexperience;
        }
        public worker(string workername)
        {
            this.Workername = workername;
        }
        public worker()
        {

        }
    }
}
