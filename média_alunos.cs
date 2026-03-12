        Console.WriteLine("=============Qual opção você escolhe?===============");
        Console.WriteLine("1 - Média de duas notas");
        Console.WriteLine("2 - Média de três notas");
        Console.WriteLine("3 - Média de quatro notas");
        Console.WriteLine("4 - Média de cinco notas");

        int notas = int.Parse(Console.ReadLine()!);
        Console.WriteLine("====================================================");

        if (notas == 1)
        {
            Console.Write("Digite a primeira nota: ");
            double not1 = double.Parse(Console.ReadLine()!);

            Console.Write("Digite a segunda nota: ");
            double not2 = double.Parse(Console.ReadLine()!);

            double media = (not1 + not2) / 2;

            Console.WriteLine("A média das notas é: " + media);
            Console.WriteLine("====================================================");
        }

        else if (notas == 2)
        {
            Console.Write("Digite a primeira nota: ");
            double not1 = double.Parse(Console.ReadLine()!);

            Console.Write("Digite a segunda nota: ");
            double not2 = double.Parse(Console.ReadLine()!);

            Console.Write("Digite a terceira nota: ");
            double not3 = double.Parse(Console.ReadLine()!);

            double media = (not1 + not2 + not3) / 3;

            Console.WriteLine("A média das notas é: " + media);
            Console.WriteLine("====================================================");
        }
        else if (notas == 3){

            Console.Write("Digite a primeira nota: ");
            double not1 = double.Parse(Console.ReadLine()!);

            Console.Write("Digite a segunda nota: ");
            double not2 = double.Parse(Console.ReadLine()!);

            Console.Write("Digite a terceira nota: ");
            double not3 = double.Parse(Console.ReadLine()!);

            Console.Write("Digite a quarta nota: ");
            double not4 = double.Parse(Console.ReadLine()!);

            double media = (not1 + not2 + not3 + not4) / 4;

            Console.WriteLine("A média das notas é: " + media);
            Console.WriteLine("====================================================");        
}     
        else if (notas == 4){
                
            Console.Write("Digite a primeira nota: ");
            double not1 = double.Parse(Console.ReadLine()!);

            Console.Write("Digite a segunda nota: ");
            double not2 = double.Parse(Console.ReadLine()!);

            Console.Write("Digite a terceira nota: ");
            double not3 = double.Parse(Console.ReadLine()!);

            Console.Write("Digite a quarta nota: ");
            double not4 = double.Parse(Console.ReadLine()!);

            Console.Write("Digite a quinta nota: ");
            double not5 = double.Parse(Console.ReadLine()!);

            double media = (not1 + not2 + not3 + not4 + not5) / 5;

            Console.WriteLine("A média das notas é: " + media);
            Console.WriteLine("====================================================");        
}       else
{
        Console.WriteLine("Digite números validos!!");
}
        
