using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class ClasseNormal
    {
        public int variavelClasseNormal;
    }

    class ClasseSingleton
    {
        static ClasseSingleton _instancia;

        public static ClasseSingleton Instancia
        {
            get { return _instancia ?? (_instancia = new ClasseSingleton()); }
        }

        private ClasseSingleton() { }

        public string Mensagem { get; set; }
    }

    static public class ClasseEstatica
    {
        private static readonly int variavelEstatica;

        // Construtor Static: é executado somente uma vez quando o tipo for usado.
        static ClasseEstatica()
        {
            variavelEstatica = 1;
        }

        public static string ExibirValor()
        {
            return string.Format("O valor da variável estática é {0}", variavelEstatica);
        }

        public static string Mensagem { get; set; }
    }
}
