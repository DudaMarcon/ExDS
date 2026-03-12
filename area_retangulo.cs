Console.WriteLine("Qual a altura do retângulo?(em cm) ");
double alt = double.Parse(Console.ReadLine()!);

Console.WriteLine("Qual a base do retângulo?(em cm) ");
double bas = double.Parse(Console.ReadLine()!);

double area = alt * bas;

Console.WriteLine("A área do retângulo é: " + area);