using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var ClasseNormal = new ClasseNormal { variavelClasseNormal = new Random().Next()};
            Console.WriteLine("Uso de classe Normal: " + ClasseNormal.variavelClasseNormal);

            string valorRetornado = ClasseEstatica.ExibirValor();
            Console.WriteLine("Uso de classe Static: " + valorRetornado);

            var variavelSingleton = ClasseSingleton.Instancia;
            variavelSingleton.Mensagem = "Teste";
            Console.WriteLine("Uso de classe Singleton: " + variavelSingleton.Mensagem);

            //Teste de instâncias Singleton
            var outraVariavelSingleton = ClasseSingleton.Instancia;
            Console.WriteLine("Verifcando se as instâncias são as mesmas: " + variavelSingleton.Equals(outraVariavelSingleton));
            Console.WriteLine(outraVariavelSingleton.Mensagem);

            Console.Read();
        }
    }
}
