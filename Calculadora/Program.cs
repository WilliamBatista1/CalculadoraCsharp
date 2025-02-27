
namespace Calculadora
{
    internal class Program
    {
        public static void Main()
        {

            Console.WriteLine("Qual operação deseja fazer?");
            Console.WriteLine("1 - Divisão");
            Console.WriteLine("2 - Multiplicação");
            Console.WriteLine("3 - Soma");
            Console.WriteLine("4 - Subtração");

            int Operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado;

            switch (Operacao)
            {
                case 1:
                    resultado = Divisao(num1, num2);
                    Console.WriteLine("Resultado da divisão: " + resultado);
                    break;
                case 2: 
                    resultado = Multiplicacao(num1, num2);
                    Console.WriteLine("Resultado da multiplicação: " + resultado);
                    break;
                case 3: 
                    resultado = Soma(num1, num2);
                    Console.WriteLine("Resultado da soma: " + resultado);
                    break;
                case 4:
                    resultado = Subtracao(num1, num2);
                    Console.WriteLine("Resultado da subtração: " + resultado);
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }
        }

        private static int Subtracao(int num1, int num2)
        {
            return num1 - num2;
        }

        private static int Soma(int num1, int num2)
        {
            return num1 + num2;
        }


        public static int Divisao(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
                return 0;
            }
            return num1 / num2;
        }


        public static int Multiplicacao(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
