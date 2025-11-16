double a, b, c, delta, x1, x2;

Console.Clear();

Console.WriteLine("-- Encontre o X da equação {ax² = bx = c} --");

Console.Write("Digite o valor de A: ");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor de B: ");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor de C: ");
c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Equação informada é ({a})x² = ({b})x + ({c})");

if (a == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("O valor informado para A é inválido. A equação não é de 2º grau.");
}
else
{
    delta = Math.Pow(b, 2) - 4 * a * c;

    Console.WriteLine($"Delta = {delta:N2}");

    if (delta < 0)

    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("A equação não possui raízes reais");
    }
    else
    {
        x1 = (-b + Math.Sqrt(delta)) / (2 * a);

        if (delta == 0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"x = {x1:N2}");
        }
        else
        {
            x2 = (-b + Math.Sqrt(delta)) / (2 * a);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"x1 - = {x1:N2}");
            Console.WriteLine($"x1 - = {x2:N2}");

        }
    }
}

Console.ResetColor();