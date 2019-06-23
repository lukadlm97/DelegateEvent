using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void WorkPreformedHendler(int hours, WorkType workType);

    class Program
    {
        static void Main(string[] args)
        {
        }
        static void WorkPreformed1(int hours,WorkType workType)
        {
            Console.WriteLine("WorkPreformed1 called!");
        }
        static void WorkPreformed2(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPreformed2 called!");
        }
    }
    public enum WorkType
    {
        GoToMeeetings,
        Golf,
        GenerateReports
    }
}
