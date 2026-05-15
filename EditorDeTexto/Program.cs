using System;

namespace EditorDeTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            string caminho = "";
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("0 -> Abrir um arquivo existente\n1 -> Criar um novo arquivo de texto\n2 -> Sair da aplicação");
            char op = char.Parse(Console.ReadLine());
            if (op == '0' || op == '1')
            {
                Console.WriteLine("Em qual caminho você deseja criar ou abrir seu texto?");
                caminho = Console.ReadLine();
            }
            //Escolher o que fazer
            switch (op)
            {
                //Enum
                case '0': Abrir(caminho); break;
                case '1': Editar(caminho); break;
                case '2': System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Abrir(string caminho)
        {//validação do caminho
            Console.Clear();
            Console.WriteLine("Texto atual:");
            using (var arquivo = new StreamReader(caminho))
            {
                string texto = arquivo.ReadToEnd();
                Console.WriteLine(texto);
            }
            Console.WriteLine("");
            Console.WriteLine("Você deseja sobrescrever o arquivo atual? S/N");
            string existe = Console.ReadLine();
            if (existe == "S") Editar(caminho); //evitar
            Menu();
        }
        static void Editar(string caminho)
        {
            Console.Clear();
            Console.WriteLine("Digite o seu texto abaixo ou use ESC para sair");
            var texto = string.Empty;//
            do
            {
                texto += Console.ReadLine();
                texto += Environment.NewLine;

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(texto, caminho);
        }

        static void Salvar(string texto, string caminho)
        {
            Console.Clear();
            if (!string.IsNullOrEmpty(caminho))// !=
            {
                using (var arquivo = new StreamWriter(caminho))
                {
                    arquivo.Write(texto);
                }
            }
            Console.WriteLine($"Arquivo salvo em {caminho} com sucesso");
            Menu();
        }
    }
}
