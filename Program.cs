using System;

namespace Calculadora_Projeto;

class Calculadora
{
    enum Opcao
    {
        Somar = 1,
        Subtrair,
        Multiplicar,
        Dividir,
        Potenciacao,
        Raiz,
        Sair,
    }

    static void Main()
    {
        Menu();
    }

    static private void Menu()
    {
        Console.Clear();
        Console.WriteLine("Escolha o operador\n");
        Console.WriteLine("1 - Somar\n2 - Subtrair\n3 - Multiplicação\n4 - Divisão\n5 - Potenciação\n6 - Raiz\n7 - Sair\n");
        Console.Write("Digite a sua opção: ");

        // Converte de string para int passado pelo usuário e passa o valor índice desse ao Enum Opcao
        Opcao opcaoSelecionada = (Opcao)int.Parse(Console.ReadLine()!);

        switch (opcaoSelecionada)
        {
            case Opcao.Somar:
                Somar.ObterSoma();
                break;
            case Opcao.Subtrair:
                Subtrair.ObterSubtracao();
                break;
            case Opcao.Multiplicar:
                Multiplicar.ObterMultiplicacao();
                break;
            case Opcao.Dividir:
                Dividir.ObterDivisao();
                break;
            case Opcao.Potenciacao:
                Potencia.ObterPotencia();
                break;    
            case Opcao.Raiz:
                Raiz.ObterRaiz();
                break;     
            case Opcao.Sair:
                Console.WriteLine("\nFechando calculadora...\n");
                Thread.Sleep(1000);
                break;
            default:
                Console.Write("\nOpção inválida. Executando novamente...\n");
                Thread.Sleep(2000);
                Menu();
                break;
        }
    }

    class Somar
    {
        public static void ObterSoma()
        {
            Console.Clear();
            Console.WriteLine("Operador: soma (+)\n");
            Console.Write($"Escolha o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine()!);
            Console.Write($"Escolha o segundo número: ");
            int num2 = int.Parse(Console.ReadLine()!);

            int resultado = num1 + num2; // Cast: conversão de int para float
            Console.WriteLine($"\nResultado: {resultado}\n");

            Console.WriteLine("Deseja fazer outro calculo?\n\n1 - Sim\n2 - Não");
            Console.Write("\nDigite a sua opção: ");
            int escolha = int.Parse(Console.ReadLine()!);

            switch (escolha)
            {
                case 1:
                    ObterSoma();
                    break;
                default:
                    Menu();
                    break;
            }
        }
    }

    class Subtrair
    {
        public static void ObterSubtracao()
        {
            Console.Clear();
            Console.WriteLine("Operador: subtração (-)\n");
            Console.Write($"Escolha o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine()!);
            Console.Write($"Escolha o segundo número: ");
            int num2 = int.Parse(Console.ReadLine()!);

            int resultado = num1 - num2;
            Console.WriteLine($"\nResultado: {resultado}\n");

            Console.WriteLine("Deseja fazer outro calculo?\n\n1 - Sim\n2 - Não");
            Console.Write("\nDigite a sua opção: ");
            int escolha = int.Parse(Console.ReadLine()!);

            switch (escolha)
            {
                case 1:
                    ObterSubtracao();
                    break;
                default:
                    Menu();
                    break;
            }
        }
    }

    class Multiplicar
    {
        public static void ObterMultiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Operador: multiplicação (x)\n");
            Console.Write($"Escolha o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine()!);
            Console.Write($"Escolha o segundo número: ");
            int num2 = int.Parse(Console.ReadLine()!);

            int resultado = num1 * num2;
            Console.WriteLine($"\nResultado: {resultado}\n");

            Console.WriteLine("Deseja fazer outro calculo?\n\n1 - Sim\n2 - Não");
            Console.Write("\nDigite a sua opção: ");
            int escolha = int.Parse(Console.ReadLine()!);

            switch (escolha)
            {
                case 1:
                    ObterMultiplicacao();
                    break;
                default:
                    Menu();
                    break;
            }
        }
    }

    class Dividir
    {
        public static void ObterDivisao()
        {
            Console.Clear();
            Console.WriteLine("Operador: divisão (/)\n");
            Console.Write($"Escolha o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine()!);
            Console.Write($"Escolha o segundo número: ");
            int num2 = int.Parse(Console.ReadLine()!);

            float resultado = (float)num1 / (float)num2;
            Console.WriteLine($"\nResultado: {resultado}\n");

            Console.WriteLine("Deseja fazer outro calculo?\n\n1 - Sim\n2 - Não");
            Console.Write("\nDigite a sua opção: ");
            int escolha = int.Parse(Console.ReadLine()!);

            switch (escolha)
            {
                case 1:
                    ObterDivisao();
                    break;
                default:
                    Menu();
                    break;
            }
        }
    }

    class Potencia
    {
        public static void ObterPotencia()
        {
            Console.Clear();
            Console.WriteLine("Operador: potencia\n");
            Console.Write($"Escolha a base: ");
            int baseNum = int.Parse(Console.ReadLine()!);
            Console.Write($"Escolha o expoente: ");
            int expoente = int.Parse(Console.ReadLine()!);

            /* A grande diferença entre ele e a precisão após a vírgula

            float: suporta até 9 números após a vírgula
            double: suporta até 17 números após a vírgula
            decimal: suporta até 29 números após a vírgula  

            Quantos mais números mais pesado fica a variável */

            int resultado = (int)Math.Pow(baseNum, expoente); // Calcula a potencia do número
            Console.WriteLine($"\nResultado: {resultado}\n");

            Console.WriteLine("Deseja fazer outro calculo?\n\n1 - Sim\n2 - Não");
            Console.Write("\nDigite a sua opção: ");
            int escolha = int.Parse(Console.ReadLine()!);

            switch (escolha)
            {
                case 1:
                    ObterPotencia();
                    break;
                default:
                    Menu();
                    break;
            }
        }
    }

    class Raiz
    {
        public static void ObterRaiz()
        {
            Console.Clear();
            Console.WriteLine("Operador: raiz\n");
            Console.Write($"Escolha um número: ");
            int num = int.Parse(Console.ReadLine()!);

            /* A grande diferença entre ele e a precisão após a vírgula

            float: suporta até 9 números após a vírgula
            double: suporta até 17 números após a vírgula
            decimal: suporta até 29 números após a vírgula  

            Quantos mais números mais pesado fica a variável */

            double resultado = Math.Sqrt(num); // Calcula a raiz do número
            Console.WriteLine($"\nResultado: {resultado}\n");

            Console.WriteLine("Deseja fazer outro calculo?\n\n1 - Sim\n2 - Não");
            Console.Write("\nDigite a sua opção: ");
            int escolha = int.Parse(Console.ReadLine()!);

            switch (escolha)
            {
                case 1:
                    ObterRaiz();
                    break;
                default:
                    Menu();
                    break;
            }
        }
    }
}
