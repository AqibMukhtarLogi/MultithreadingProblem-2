using System;
using System.Threading;
using System.Collections.Generic;

namespace Multithreading___Problem_2
{
    class Program
    {
        static void Print(Object obj)
        {
            for(int i = (int) obj; i <= 100; i += 10)
                Console.WriteLine("Thread: {0}, Number: {1}", Thread.CurrentThread.GetHashCode(), i);
        }
        static void Main(string[] args)
        {
            List<Thread> threads = new List<Thread>();
            for (int i = 0; i < 10; i++)
            {
                threads.Add(new Thread(new ParameterizedThreadStart(Print)));
                threads[i].Start(i + 1);
            }

        }
    }
}
