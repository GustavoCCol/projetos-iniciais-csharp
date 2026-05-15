using System;
using System.Diagnostics;
using System.Threading;

namespace Cronometro
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
            //Criar o cronômetro
            Stopwatch stopWatch = new Stopwatch();

            //Rodar o programa
            Console.WriteLine("Bem-vindo ao cronômetro do Gustavo!");
            Console.WriteLine("Começar o cronômetro?");
            string? start = Console.ReadLine();
            if (start != null) stopWatch.Start(); ;
            StopTime(stopWatch);

            //Mostrar o tempo final
            string tempo_final = ShowTime(stopWatch);
            Console.WriteLine($"O tempo final foi de {tempo_final}");
        }
        static void StopTime(Stopwatch stopwatch)
        {
            while (true)
            {
                Console.WriteLine("Parar o cronômetro?");
                string? stop = Console.ReadLine();
                if (stop != null)
                {
                    stopwatch.Stop();
                    break;
                }
                Thread.Sleep(1000);
            }
        }
        static string ShowTime(Stopwatch stopwatch)
        {
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            return elapsedTime;
        }
    }
}

