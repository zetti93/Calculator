static void Soma()
{
    Console.Clear();

    Console.WriteLine("Primeiro Valor");
    double v1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Segundo Valor");
    double v2 = double.Parse(Console.ReadLine());

    Console.WriteLine();

    var resultado = v1 + v2;

    Console.WriteLine($"O resultado da soma é: {resultado}");

    Console.ReadKey();
}

static void Subtracao()
{
    Console.Clear();

    Console.WriteLine("Primeiro Valor");
    double v1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Segundo Valor");
    double v2 = double.Parse(Console.ReadLine());

    Console.WriteLine("");

    var resultando = v1 - v2;

    Console.WriteLine($"O resultado da subtração é: {resultando}");

    Console.ReadKey();
}

static void Divisao()
{
    Console.Clear();

    Console.WriteLine("Primeiro Valor:");
    double v1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Segundo Valor:");
    double v2 = double.Parse(Console.ReadLine());

    Console.WriteLine();

    var resultado = v1 / v2;

    Console.WriteLine($"O resultado da divisão é: {v1 / v2}");

    Console.ReadKey();
}

static void Multiplicacao()
{
    Console.Clear();

    Console.WriteLine("Primeiro Valor: ");
    var v1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Segundo Valor: ");
    var v2 = double.Parse(Console.ReadLine());

    Console.WriteLine();

    var resultado = v1 * v2;

    Console.WriteLine($"O Resultado a multiplicação é: {resultado}");

    Console.ReadKey();
}

static void Menu()
{
    string novamente = "S";

    while (novamente.Equals("S") || novamente.Equals("s"))
    {
        Console.Clear();

        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine();
        Console.WriteLine("--------------------------");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("--------------------------");
        Console.WriteLine("Selecione a opção: ");
        var op = long.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                Soma();
                break;
            case 2:
                Subtracao();
                break;
            case 3:
                Divisao();
                break;
            case 4:
                Multiplicacao();
                break;
            default:
                Menu();
                break;
        }

        Console.WriteLine("Deseja fazer outro Calculo? (S/N)");
        novamente = Console.ReadLine();
    }
}

Menu();