using System;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace EditorHTML
{
    public class Viewer
    {
        public static void Show(string text, bool edit)
        {
            if (!edit)
            {
                Console.Write("Qual o caminho do arquivo que deseja abrir?");
                string caminho = Console.ReadLine();
                string? texto;
                using (var arquivo = new StreamReader(caminho))
                {
                    texto = arquivo.ReadToEnd();
                }
                Screen(texto);
            }
            else Screen(text);
        }

        public static void Screen(string text)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("-----------");
            Replace(text);
            Console.WriteLine("\n-----------");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            ((words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>'))
                        )
                    );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}