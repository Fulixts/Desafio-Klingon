using System;
using System.IO;

namespace Desafio_Klingon
{
    public class Program : Metodos
    {
        public static void Main(string[] args)
        {
            /* Por Favor, Salve seu arquivo .txt com o texto em klingon
             * e coloque o caminho em que ele se encontra em sua máquina 
             */
            string Ph = File.ReadAllText("C:\\Git\\klingon-textoB-ordenado.txt");

            Console.WriteLine($"O numero de Preposições é : {Preposicao(Ph)} \n");

            Console.WriteLine(Verbos(Ph) + "\n");

            foreach (var item in Ordenar(Ph))
            {
                Console.Write(item + " ");
            }

            /* esse WriteLine esta aqui so para melhorar a vizualização no console
             * então pode desconsiderar
             */
            Console.WriteLine("\n");

            Console.WriteLine("Infelizmente não compreendi os números na base vigesimal em klingon, então essa vou ficar devendo rs");

        }
    }
}
