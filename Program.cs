using System;

namespace ProjetoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
           string opcao, sair = "" ;


            do
            {

                try
                {
                    optionsMenu();
                    opcao = Console.ReadLine();


                    switch (opcao)
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

                        case "7":
                            Converter();
                            break;

                        case "8":
                            Sobre();
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Opção Inválida!");
                            Console.ResetColor();
                            break;
                    }



                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Deseja retornar ao menu principal? S/N?");
                    Console.ResetColor();
                    sair = Console.ReadLine().ToUpper();


                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Limite de numeros digitados atingido...");
                    Console.ResetColor();
                    Console.WriteLine("Aperte uma tecla para voltar ao menu principal...");
                    Console.ReadKey();
                }
                catch (DivideByZeroException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Não é possivel dividir por zero!");
                    Console.ResetColor();
                    Console.WriteLine("Aperte uma tecla para voltar ao menu principal...");
                    Console.ReadKey();
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Número em formato inválido!");
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Aperte uma tecla para voltar ao menu...");
                    Console.ResetColor();
                    Console.ReadKey();
                }



            } while (sair != "N" && sair != "NAO");

          
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Obrigado por utilizar o programa!!!");
            Console.WriteLine("Compartilhe com seus amigos! :)");
            Console.ResetColor();

        }

        static void addition()
        {
            int numero1, numero2, resultado;

            Console.Write("Digite o 1° numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o 2° numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            resultado = numero1 + numero2;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"A SOMA DE {numero1}+{numero2} É = {resultado}.");
            Console.ResetColor();
        }

        static void subtration()
        {
            int numero1, numero2, resultado;

            Console.Write("Digite o 1° numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o 2° numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            resultado = numero1 - numero2;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"A SUBTRAÇÃO DE {numero1}-{numero2} É = {resultado}");
            Console.ResetColor();
        }

        static void division()
        {
            decimal numero1, numero2, resultado;

            Console.Write("Digite o 1° numero: ");
            numero1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o 2° numero: ");
            numero2 = Convert.ToDecimal(Console.ReadLine());

            while (numero2 == 0)
            {
                throw new DivideByZeroException();
            }

            resultado = numero1 / numero2;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"A DIVISÃO DE {numero1}/{numero2} É = {resultado}");
            Console.ResetColor();
        }

        static void multiplication()
        {
            double numero1, numero2, resultado;

            Console.Write("Digite o 1° numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o 2° numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            resultado = numero1 * numero2;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"A MULTIPLICAÇÃO DE {numero1}*{numero2} É = {resultado}");
            Console.ResetColor();
        }

        static void squareroot()
        {
            double numero1, resultado;

            Console.Write("Digite um numero: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            resultado = Math.Sqrt(numero1);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"A RAIZ QUADRADA DE {numero1} É = {resultado}");
            Console.ResetColor();
        }

        static void potentiation()
        {
            double numero1, numero2, resultado;

            Console.Write("Digite a base: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o expoente: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            resultado = Math.Pow(numero1, numero2);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"O RESULTADO DA POTENCIÇÃO DE BASE{numero1}, E EXPOENTE{numero2} É = {resultado}");
            Console.ResetColor();
        }

        static void Converter()
        {
            double milhas, resultado;
            double km = 1.609;

            Console.Write("Digite a distância em Milhas: ");
            milhas = double.Parse(Console.ReadLine());
            resultado = milhas * km;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"O RESULTADO DA CONVERSÃO É:{resultado} KM.");
            Console.ResetColor();

        }

        static void Sobre()
        {
            Console.WriteLine("Calculadora Versão 1.0.0.");
            Console.WriteLine("Programa desenvolvido para a matéria de PC1 da EtecAb.");
            Console.WriteLine("Programador responsável pelo projeto: Carlos Eduardo.");
            Console.WriteLine("Página do GitHub: https://github.com/KaduVieira13");
        }

        static void optionsMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("-------------- CALCULADORA ----------------\n");

            Console.WriteLine("◄► 1- Adição        | ◄► 5- Raiz Quadrada");
            Console.WriteLine("◄► 2- Subtração     | ◄► 6- Potenciação  ");
            Console.WriteLine("◄► 3- Divisão       | ◄► 7- Conversor Mi/Km  ");
            Console.WriteLine("◄► 4- Multiplicação | ◄► 8- Sobre");
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("Selecione a opção desejada: ");
            Console.ResetColor();

        }
    }
}


