namespace Calculadora
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Qual operação deseja fazer?");
            Console.WriteLine("1 - Divisão");
            Console.WriteLine("2 - Multiplicação");

            int Operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado;

            switch (Operacao)
            {
                case 1: // Divisão
                    resultado = Divisao(num1, num2);
                    Console.WriteLine("Resultado da divisão: " + resultado);
                    break;
                case 2: // Multiplicação
                    resultado = Multiplicacao(num1, num2);
                    Console.WriteLine("Resultado da multiplicação: " + resultado);
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }
        }

        // Método para realizar a divisão
        public static int Divisao(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
                return 0;
            }
            return num1 / num2;
        }

        // Método para realizar a multiplicação
        public static int Multiplicacao(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
