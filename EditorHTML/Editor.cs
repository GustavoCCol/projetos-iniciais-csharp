using System;
using System.Runtime.InteropServices;
using System.Text;

namespace EditorHTML
{
    public static class Editor
    {
        public static void Show()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");
            Start();
        }
        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("-----------");
            Console.WriteLine("Deseja salvar o arquivo? S/N");
            var option = Console.ReadLine();
            if (option == "S")
            {
                Console.WriteLine("Em qual caminho deseja salvar o arquivo?");
                var caminho = Console.ReadLine();
                Save(file.ToString(), caminho);
            }
        }
        public static void Save(string text, string caminho)
        {
            Console.Clear();
            if (caminho != null)
            {
                using (var arquivo = new StreamWriter(caminho))
                {
                    arquivo.Write(text);
                }
            }
            Console.WriteLine($"Arquivo salvo em {caminho} com sucesso");
            Viewer.Show(text.ToString(), true);
        }
    }
}