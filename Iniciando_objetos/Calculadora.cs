namespace Calculadora
{
    public class Operacoes
    {
        public static void Adicao(
            decimal valor1,
            decimal valor2
        )

        {
            Console.WriteLine($"A soma dos números {valor1} + {valor2} = {valor1 + valor2}");
        }

        public static void Subtraçao(
            decimal valor1,
            decimal valor2
        )

        {
            Console.WriteLine($"A subtração dos números {valor1} + {valor2} = {valor1 - valor2}");
        }

        public static void Multiplicacao(
            decimal valor1,
            decimal valor2
        )

        {
            Console.WriteLine($"A multiplicação dos números {valor1} * {valor2} = {valor1 * valor2}");
        }
        public static void Divisao(
        decimal valor1,
        decimal valor2
        )

        {
            Console.WriteLine($"A divisão dos números {valor1} / {valor2} = {valor1 / valor2}");
        }
    }
}