using System.Diagnostics.Metrics;

namespace Primeiro_Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exemplos
            /*string message = "Ola Mundo!";
            Console.WriteLine(message);
            message = "Ola Gilberto";
            Console.WriteLine(message);
            Console.WriteLine(message.Length);
            Console.WriteLine(message.Contains("Gilberto"));
            Console.WriteLine(message.StartsWith("O"));
            int a = 5;
            int b = 10;
            int total = a + b;
            Console.WriteLine(total);

            if (total == 15)
            {
                Console.WriteLine("É igual a 15.");
            }
            else
            {
                Console.WriteLine("Não é igual.");
            }*/
            #endregion

            #region Calculadora
            /*int numero1, numero2, resultado = 0;
            string operacao;

            Console.Write("Informe o primeiro número: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.Write("Informe operação número: ");
            operacao = Console.ReadLine();

            if (operacao == "+")
            {
                resultado = numero1 + numero2;
            }
            else if (operacao == "-")
            {
                resultado = numero1 - numero2;
            }
            else if (operacao == "*")
            {
                resultado = numero1 * numero2;
            }
            else if (operacao == "/")
            {
                resultado = numero1 / numero2;
            }

            Console.WriteLine("Resultado: " + resultado);*/
            #endregion

            #region Estruturas de Repetição
            /*int counter = 1;
            while (counter < 10)
            {
                Console.WriteLine($"While {counter}");
                counter++;
            }

            counter = 1;
            do
            {
                Console.WriteLine($"Do While {counter}");
                counter++;
            } while (counter <= 10);


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"For {i}");

            }*/
            #endregion

            #region Listas
            /*string[] names = new string[4] //new string[] é usado para estanciar
            {
                "Gilberto", "Islaine", "Marineuza", "Jade"
            };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            List<string> list = new List<string>()
            {
                 "Gilberto", "Islaine", "Marineuza", "Jade"
            };

            list.Add("Teste");
            list.Remove("Gilberto");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }*/
            #endregion


        }
    }
}
