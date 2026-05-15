using System;

namespace ProjetoCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            /*Lista de tarefas para a calculadora
            1. Fazer o menu com as quatro operações
            2. Fazer as funções de cada operação
            3. Decidir como entregar a aplicação ao usuário
            */
            Console.WriteLine("Bem-vindo à calculadora do Gustavo!\n");
            string? criterioParada = "S";
            do
            {
                Console.WriteLine("Qual operação deseja fazer?\nSoma[0]\nSubtração[1]\nMultiplicação[2]\nDivisão[3]\nSair[4]");
                string? parametroInicial = Console.ReadLine();
                string resultado = Menu(parametroInicial);
                if (resultado == "") break;
                Console.WriteLine($"O seu resultado final foi: {resultado}");
                Console.WriteLine("Deseja fazer mais alguma operação? S/N");
                criterioParada = Console.ReadLine();
            } while (criterioParada == "S");
        }
        static string Menu(string parametro)
        {
            string resultado = "";
            switch (parametro)
            {
                case "0":
                    resultado = Soma();
                    break;
                case "1":
                    resultado = Subtracao();
                    break;
                case "2":
                    resultado = Multiplicacao();
                    break;
                case "3":
                    resultado = Divisao();
                    break;
                case "4":
                    System.Environment.Exit(0);
                    break;
            }
            return resultado;
        }
        static string Soma()
        {
            Console.WriteLine("Qual o primeiro valor a ser somado?");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual o segundo valor a ser somado?");
            double v2 = Convert.ToDouble(Console.ReadLine());
            return Convert.ToString(v1 + v2);
        }
        static string Subtracao()
        {
            Console.WriteLine("Qual o valor a ser subtraído?");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual o valor a subtrair?");
            double v2 = Convert.ToDouble(Console.ReadLine());
            return Convert.ToString(v1 - v2);
        }
        static string Multiplicacao()
        {
            Console.WriteLine("Qual o valor a ser multiplicado?");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual o valor a multiplicar?");
            double v2 = Convert.ToDouble(Console.ReadLine());
            return Convert.ToString(v1 * v2);
        }
        static string Divisao()
        {
            Console.WriteLine("Qual o valor a ser divido?");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual o valor divisor?");
            double v2 = Convert.ToDouble(Console.ReadLine());
            return Convert.ToString(v1 / v2);
        }
    }
}