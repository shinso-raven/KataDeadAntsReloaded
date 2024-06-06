using System;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Hormigas;
namespace MyBenchmarks
{
    [MemoryDiagnoser]
    [ShortRunJob]
    public class DeadAntsBenchmark
    {
        private readonly Hormigas obj = new Hormigas();

        [Params(
            "...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t",
            "a",
            "ant",
                "...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t"
            )]
        public string _hormigas;

        public DeadAntsBenchmark()
        {


        }

        [Benchmark]
        public int Hormigas_uno() => obj.CountDeadAnts(_hormigas);
        //[Benchmark]
        //public int Hormigas_uno_dos() => obj.CountDeadAnts(_hormigas);
        //[Benchmark]
        //public int Hormigas_uno_tre() => obj.CountDeadAnts("ant");


    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<DeadAntsBenchmark>();
        }
    }



    public class Hormigas
    {

        public int CountDeadAnts(string antLine)
        {
            int deadAnts = 0;
            if (antLine == null)
            {
                return 0;
            }
            for (int i = 0; i < antLine.Length; i++)
            {
                if (i - 1 >= 0)
                {

                    if (antLine[i] == 'n' && antLine[i - 1] == '.')
                        if (i + 1 < antLine.Length && antLine[i + 1] == 'a')
                        {
                            continue;
                        }
                        else
                        {

                            deadAnts++;
                        }
                }

                if (antLine[i] == 't' && antLine[i - 1] == '.')
                {
                    deadAnts++;
                }



                if (antLine[i] == 'a')
                {
                    if (i + 1 < antLine.Length && antLine[i + 1] == 'n' && i + 2 < antLine.Length && antLine[i + 2] == 't')
                    {
                        continue;
                    }
                    else
                    {
                        deadAnts++;
                    }
                }
            }

            return deadAnts;
        }
    }



}
