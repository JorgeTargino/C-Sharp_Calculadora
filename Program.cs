using System;

namespace Program
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Observe as operações e escolha:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("--------------");
            Console.WriteLine("Selecione uma das opções a baixo: ");
            short res = short.Parse(Console.ReadLine());

            switch (res) 
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Sair(); System.Environment.Exit(0);break;
                default: Menu(); break;
            }
        }    
        static void Soma()
        {
            
            Console.Clear();
            Console.WriteLine("Você escolheu a operação de Soma: ");
            Console.Write("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            //Console.WriteLine(v1);

            Console.Write("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine($"A resultado da soma  é: {resultado}");

            Console.ReadKey();
            Menu();
        }    
             
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Você escolheu a operação de Subtração: ");
            Console.Write("Digie o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1-v2;
            Console.WriteLine($"O resultado da subtração é: {resultado} ");
            
            Console.ReadKey();
            Menu();
        }
        
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Você escolheu a operação de Divisão: ");    
            Console.Write("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1/v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            
            Console.ReadKey();
            Menu();
        }
      
        static void Multiplicacao()     
        {
            Console.Clear();
            Console.WriteLine("Você escolheu a operação de Multiplicação ");
            Console.Write("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1*v2;
            Console.WriteLine($"O resultado da Multiplicação é: {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Sair()       
        {
            Console.WriteLine("Você escolheu sair. Ate logo ;) ");
        }
    }
}