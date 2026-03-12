        Console.WriteLine("=============Qual opção você escolhe?===============");
        Console.WriteLine("1 - Converter fahrenheit para celsius");
        Console.WriteLine("2 - Converter celsius para fahrenheit");

        int resp = int.Parse(Console.ReadLine()!);
        Console.WriteLine("====================================================");

        if (resp == 1)
        {
            Console.Write("Digite a temperatura em fahrenheit: ");
            double fahr = double.Parse(Console.ReadLine()!);

            double cels = (fahr - 32) * 5.0 / 9.0;

            Console.WriteLine("A temperatura em celsius é " + cels + " °C");
            Console.WriteLine("====================================================");
        }

        else if (resp == 2)
        {
            Console.Write("Digite a temperatura em celsius: ");
            double cels = double.Parse(Console.ReadLine()!);

            double fahr = (cels * 9.0 / 5.0) + 32;

            Console.WriteLine("A temperatura em Fahrenheit é " + fahr + " °F");
            Console.WriteLine("====================================================");
        }

        else
        {
            Console.WriteLine("Opção inválida!");
            Console.WriteLine("====================================================");
        }
    
