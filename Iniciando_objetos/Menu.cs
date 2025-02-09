namespace Menu
{
    public class MenuOperacoes
    {
        public static void ImprimirMenu()
        {
            Console.Write("Qual tipo de operação você quer: ");
            Console.WriteLine("\n(+) Adição");
            Console.WriteLine("(-) Subtração");
            Console.WriteLine("(*) Multiplicação");
            Console.WriteLine("(/) Divisão");
            Console.Write("\nDigite: ");
        }
    }
}