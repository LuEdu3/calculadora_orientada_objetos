int n1;
int n2;

Console.WriteLine("Calculadora: ");
Console.Write("Digite o primeiro número");
if(int.TryParse(Console.ReadLine(), out n1)){
Console.Write("Digite o segundo número");
if(int.TryParse(Console.ReadLine(), out n2)){

Console.Write("Qual tipo de operação você quer: ");
Console.WriteLine("(+) Adição");
Console.WriteLine("(-) Subtração");
Console.WriteLine("(*) Multiplicação");
Console.WriteLine("(/) Divisão");

if(!int.TryParse(Console.ReadLine(),out int operacao))
{
    switch(operacao)
    {
        case '+':
        Console.WriteLine($"O resultado da adição é: {n1+n2}");
        break;
    
        case '-':
        Console.WriteLine($"O resultado da subtração é: {n1-n2}");
        break;

        case '*':
        Console.WriteLine($"O resultado da multiplicação é: {n1*n2}");
        break;

        case '/':
        Console.WriteLine($"O resultado da operação é: {n1/n2}");
        break;
    }

}
}
}
