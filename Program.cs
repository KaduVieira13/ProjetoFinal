using System;

namespace ProjetoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
             string opcao, sair =  " ";

            Console.WriteLine("Calculadora\n");

         try
         {
             
            do
            {

                Console.WriteLine("1- Adição");
                Console.WriteLine("2- Subtração");
                Console.WriteLine("3- Divisão");
                Console.WriteLine("4- Multiplicação");
                Console.WriteLine("5- Raiz Quadrada");
                Console.WriteLine("6- Potenciação");
                Console.WriteLine("selecione a opção desejada");
                opcao = Console.ReadLine();

                switch(opcao)
                {
                    case "1":
                    addition();
                    break;

                    case "2":
                    subtration();
                    break;

                    case "3":
                    division();
                    break;

                    case "4":
                    multiplication();
                    break;

                    case "5":
                    squareroot();
                    break;

                    case "6":
                    potentiation();
                    break;
                    
                    default:
                    Console.WriteLine("Opção Inválida...");
                    break;
                }

                Console.WriteLine("Deseja retornar ao menu principal? S/N?");
                sair = Console.ReadLine().ToUpper();


            }while (sair != "N" && sair != "Nao");

          
         }
         catch (FormatException)
         {
            Console.WriteLine("Erro de digitação...");
             
         }
         catch (OverflowException)
         {
            Console.WriteLine("numero digitado errado...");
         }
         catch (DivideByZeroException)
         {
              Console.WriteLine("Não é possivel dividir por zero...");
         }
         catch (Exception)
         {
              Console.WriteLine("Erro merda...");
         }

          Console.WriteLine("Obrigado");

         

        }

        static void addition()
        {
             double numero1,numero2, resultado;

                Console.Write("digite um numero: ");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("digite um numero: ");
                numero2 = Convert.ToDouble(Console.ReadLine());

                resultado =  numero1 + numero2 ;
                Console.WriteLine($"A soma de {numero1} + {numero2} é = {resultado}.");
        }

        static void subtration()
        {
            double numero1,numero2, resultado;

                Console.Write("digite um numero: ");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("digite um numero: ");
                numero2 = Convert.ToDouble(Console.ReadLine());

                resultado =  numero1 - numero2 ;
                Console.WriteLine($"A subtração de {numero1} - {numero2} é = {resultado}");
        }

        static void division()
        {
            decimal numero1,numero2, resultado;

                Console.Write("digite um numero: ");
                numero1 = Convert.ToDecimal(Console.ReadLine());

                Console.Write("digite um numero: ");
                numero2 = Convert.ToDecimal(Console.ReadLine());

                while(numero2 == 0)
                 {
                   
                    Console.WriteLine($"{numero2} não é um divisor...Digite um numero válido");
                    numero2 = Convert.ToDecimal(Console.ReadLine());
            
                 }
                
                resultado =  numero1 / numero2 ;
                Console.WriteLine($"A divisão de {numero1} / {numero2} é = {resultado}");
        }

        static void multiplication()
        {
             double numero1,numero2, resultado;

                Console.Write("digite um numero: ");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("digite um numero: ");
                numero2 = Convert.ToDouble(Console.ReadLine());

                resultado =  numero1 * numero2 ;
                Console.WriteLine($"A multiplicação de {numero1} * {numero2} é = {resultado}");
        }

        static void squareroot()
        {
            double numero1, resultado;

                Console.Write("digite um numero: ");
                numero1 = Convert.ToDouble(Console.ReadLine());

                resultado = Math.Sqrt(numero1);
                Console.WriteLine($"A raiz quadrada de {numero1} é = {resultado}");
        }

        static void potentiation()
        {
            double numero1,numero2, resultado;

                Console.Write("digite a base: ");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("digite o expoente: ");
                numero2 = Convert.ToDouble(Console.ReadLine());

                resultado = Math.Pow(numero1, numero2);
                Console.WriteLine($"O resultado da potência de base {numero1} e expoente {numero2} é = {resultado}");
        }
    }
        }
    

