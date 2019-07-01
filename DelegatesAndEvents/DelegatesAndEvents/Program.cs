using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate int BizRulesDelegate(int x, int y);
    class Program
    {
       
        static void Main(string[] args)
        {
          /*  var worker = new Worker();
            worker.WorkPerformed += (s,e) => Console.WriteLine(e.Hours + "  " + e.WorkType);
            worker.WorkCompleted += (s,e) => Console.WriteLine("Worker is Done!");
            worker.doWork(8, WorkType.GenerateReports);
            Console.Read();*/
            BizRulesDelegate addDel = (x, y) => x + y;
            ProcessData.Process(2, 5, addDel);
        }

        

       
    }
    public enum WorkType
    {
        GoToMeeetings,
        Golf,
        GenerateReports
    }
}
