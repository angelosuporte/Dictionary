using System;
using System.Collections.Generic;
using System.IO;

namespace DictionarySortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> candidatos = new Dictionary<string, int>();

            Console.Write("Informe o path completo: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader abrirArquivo = File.OpenText(path))
                {
                    while (!abrirArquivo.EndOfStream)
                    {
                        string[] linha = abrirArquivo.ReadLine().Split(',');
                        string nome = linha[0];
                        int votos = int.Parse(linha[1]);

                        if (candidatos.ContainsKey(nome))
                        {
                            candidatos[nome] += votos;
                        }
                        else
                        {
                            candidatos[nome] = votos;
                        }
                    }

                    Console.WriteLine("Resultado: ");
                    foreach (var candidato in candidatos)
                    {
                        Console.WriteLine(candidato.Key + ": " + candidato.Value);
                    }
                    
                    Console.ReadKey();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
