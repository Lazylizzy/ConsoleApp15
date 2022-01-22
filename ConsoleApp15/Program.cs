using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {

            ArithProgression arithProgression = new ArithProgression();
            GeomProgression geomProgression = new GeomProgression();
            Console.Write("Add x=");
            int x = Convert.ToInt32(Console.ReadLine());
            arithProgression.SetStart(x);
            Console.WriteLine("new x={0} arifm.progression", arithProgression.GetNext());
            arithProgression.Reset();
            Console.WriteLine();
            geomProgression.SetStart(x);
            Console.WriteLine("new x={0} geometr.progression", geomProgression.GetNext());
            geomProgression.Reset();
            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();
        int N { get; set; }
    }
    class ArithProgression : ISeries
    {
        public int N { get; set; } = 5;
        private int x;
        public void SetStart(int x)
        {
            this.x = x;
        }
        public int GetNext()
        {
            int x1 = x + N;
            return x1;

        }
        public void Reset()
        {
            Console.WriteLine("start x={0}", x);
            return;
        }
    }
    class GeomProgression : ISeries
    {
        private int x;
        public int N { get; set; } = 2;

        public int GetNext()
        {
            int x1 = x * N;
            return x1;
        }

        public void Reset()
        {
            Console.WriteLine("start x={0}", x);
            return;
        }

        public void SetStart(int x)
        {
            this.x = x;
        }
    }
}
