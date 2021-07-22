using System;

namespace SingletonMultiThread
{
    public class Singleton
    {
        private static Singleton instance;
        private static int instances = default(int);
        private static object lockObject = new object();
        private Singleton()
        {
            instances++;
            Console.WriteLine("Instânciando no construtor privado");
            Console.WriteLine($"Número de instâncias: {instances}\n");
        }

        public static Singleton Instance
        {
            get
            {
                if (instance is null)
                {
                    lock (lockObject)
                    {
                        if (instance is null)
                            instance = new Singleton();
                    }
                }

                return instance;
            }
        }
    }
}
