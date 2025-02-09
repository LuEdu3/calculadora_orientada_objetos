using Calculadora;
using Menu;

Console.Clear();

decimal n1;
decimal n2;

Console.WriteLine("Calculadora");

return1:

Console.Write("\nDigite o primeiro número: ");
if (decimal.TryParse(Console.ReadLine(), out n1))
{

    MenuOperacoes.ImprimirMenu();

    string operacao = Console.ReadLine();

return2:

    Console.Write("\nDigite o segundo número: ");
    if (decimal.TryParse(Console.ReadLine(), out n2))
    {
        switch (operacao)
        {
            case "+":
                Operacoes.Adicao(n1, n2);
                break;

            case "-":
                Operacoes.Subtraçao(n1, n2);
                break;

            case "*":
                Operacoes.Multiplicacao(n1, n2);
                break;

            case "/":
                Operacoes.Divisao(n1, n2);
                break;
        }

    }
    else
    {
        Console.Write("Segundo número digitado errado.");
        goto return2;
    }
}

else
{
    Console.Write("Primeiro número digitado errado.");
    goto return1;
}
