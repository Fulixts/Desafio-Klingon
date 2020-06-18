using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Desafio_Klingon
{
    public class Metodos
    {
        public static int Preposicao(string text)
        {
            var list = text.Split(' ');
            return Check(list).Count();
        }

        public static IEnumerable<string> Check(string[] strings)
        {
            foreach (var s in strings.ToList().Where(x => x.Length == 3))
            {
                if (!s.Contains("d"))
                    switch (s[s.Length - 1])
                    {
                        case 's':
                        case 'l':
                        case 'f':
                        case 'w':
                        case 'k':
                            break;

                        default:
                            //Console.WriteLine(s);
                            yield return s;
                            break;
                    }
            }
        }

        public static string Verbos(string x)
        {
            string[] strings = x.Split(' ');
            ArrayList Verbos = new ArrayList();
            ArrayList VerbosPrimeiraPessoa = new ArrayList();

            foreach (var s in strings.ToList().Where(x => x.Length >= 8))
            {
                switch (s[s.Length - 1])
                {
                    case 's':
                    case 'l':
                    case 'f':
                    case 'w':
                    case 'k':
                        Verbos.Add(s);
                        switch (s[0])
                        {
                            case 's':
                            case 'l':
                            case 'f':
                            case 'w':
                            case 'k':
                                break;

                            default:
                                VerbosPrimeiraPessoa.Add(s);
                                break;
                        }
                        break;

                    default:
                        break;
                }
            }

            var y = Verbos.Count.ToString();

            var z = VerbosPrimeiraPessoa.Count.ToString();

            string result = $"Os Verbos são : {y} e Os Verbos em Primeira Pessoa são : {z} ";

            return result;
        }

        public static IEnumerable<string> Ordenar(string text)
        {
            var list = text.Split(' ');

            var chars = new List<char>(new[]
            {
                'k', 'b', 'w', 'r', 'q', 'd', 'n', 'f', 'x', 'j', 'm', 'l', 'v', 'h', 't', 'c', 'g', 'z', 'p', 's'
            });

            return Sort(list.ToList(), chars);
        }

        public static IEnumerable<string> Sort(IEnumerable<string> list, IEnumerable<char> chars)
        {
            return chars.Join(
                list,
                key => key,
                x => x[0],
                (key, item) => item);
        }
    }
}