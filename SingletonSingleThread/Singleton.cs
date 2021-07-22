using System;

namespace SingletonSingleThread
{
    public class Singleton
    {
        private static Singleton instance;
        private static int instances = default(int);

        private Singleton()
        {
            instances++;
            Console.WriteLine("Instânciando no construtor privado");
            Console.WriteLine($"Número de instâncias: {instances}\n");
        }

        public static Singleton Instance
        {
            get { return instance ?? (instance = new Singleton()); }
        }
    }
}
