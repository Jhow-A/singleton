using System;
using System.Threading.Tasks;

namespace SingletonMultiThread
{
    static class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => Thread1(),
                () => Thread2()
            );
        }

        private static void Thread1()
        {
            var s1 = Singleton.Instance;
            Console.WriteLine(nameof(Thread1));
        }

        private static void Thread2()
        {
            var s2 = Singleton.Instance;
            Console.WriteLine(nameof(Thread2));
        }
    }
}
