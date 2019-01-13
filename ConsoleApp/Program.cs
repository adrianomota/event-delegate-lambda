using System;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public delegate int BizRulesDelegate(int x, int y);

    internal class Program
    {
        private static async Task Main(string[] args)
        {
            //var data = new ProcessData();
            //Action<int, int> myAddAction = (x, y) => Console.WriteLine(x + y);
            //Action<int, int> myMultAction = (x, y) => Console.WriteLine(x * y);
            //data.ProcessAction(2, 3, myAddAction);
            //data.ProcessAction(2, 3, myMultAction);

            //var data = new ProcessData();
            //BizRulesDelegate AddDel = (x, y) => x + y;
            //BizRulesDelegate MultDel = (x, y) => x * y;
            //data.Process(2, 3, AddDel);
            //data.Process(2, 3, MultDel);

            var data = new ProcessData();
            Func<int, int, int> FuncAdd = (x, y) => x + y;
            Func<int, int, int> FuncMult = (x, y) => x * y;
            data.ProcessFunc(3, 3, FuncAdd);
            data.ProcessFunc(3, 3, FuncMult);

            //var worker = new Worker();
            ////worker.WorkPerformed += WorkPerformed;
            ////worker.WorkCompleted += WorkCompleted;
            //worker.WorkPerformed += (s, e) => Console.WriteLine($"{e.Hours} {e.WorkType}");
            //worker.WorkCompleted += (s, e) => Console.WriteLine($"Work Done!");

            //worker.DoWork(10, Enum.WorkType.Golf);

            Console.Read();
            await Task.FromResult(0);
        }

        private static void WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine($"Work Done!");
        }

        private static void WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine($"{e.Hours} {e.WorkType}");
        }
    }
}