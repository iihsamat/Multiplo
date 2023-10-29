//Stefeson

Console.Clear();

int numero1, numero2;

Console.WriteLine("--- Multiplo ---");

Console.Write("Digite um número: ");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Avaliar se é múltiplo de: ");
numero2 = Convert.ToInt32(Console.ReadLine());

if (numero1 % numero2 == 0)
{
    Console.WriteLine($"{numero1} é multiplo de {numero2}");
}
else
{
    Console.WriteLine($"{numero1} não é multiplo de {numero2}");
}