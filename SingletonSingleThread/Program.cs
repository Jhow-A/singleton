using System;

namespace SingletonSingleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando instância 1 \n");
            var s1 = Singleton.Instance;

            Console.WriteLine("Criando instância 2 \n");
            var s2 = Singleton.Instance;

            if (s1 == s2 && s1.Equals(s2))
                Console.WriteLine("Instâncias iguais");
            else
                Console.WriteLine("Instâncias diferentes");

        }
    }
}
