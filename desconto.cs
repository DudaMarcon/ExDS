Console.Write("Digite o valor do produto: ");
double prod = double.Parse(Console.ReadLine()!);

Console.Write("Digite o desconto (%): ");
double desc = double.Parse(Console.ReadLine()!);

double valorFinal = prod - (prod * desc / 100);

Console.WriteLine("O valor com desconto é: " + valorFinal);