internal class Program
{
    private static void Main(string[] args)
    {
        int opcao;

        do
        {
            do
            {

                Console.WriteLine("=========MENU=========");
                Console.WriteLine("0 - SAIR");
                Console.WriteLine("1 - EX1");
                Console.WriteLine("2 - EX2");
                Console.WriteLine("3 - EX3");
                Console.WriteLine("4 - EX4");
                Console.WriteLine("5 - EX5");
                Console.WriteLine("6 - EX6");
                Console.WriteLine("7 - EX7");

                opcao = int.Parse(Console.ReadLine());

            } while (opcao < 0 || opcao > 7);

            switch (opcao)
            {
                case 0:
                    Console.WriteLine("Obrigado por usar o sistema!");
                    break;

                case 1:
                    Console.WriteLine("Executando o ex1");
                    int Num;
                    Console.WriteLine("digite um número para contarmos até ele:");
                    Num = int.Parse(Console.ReadLine());
                    int i = 1;
                    do
                    {
                        {
                            Console.WriteLine(i);
                            i++;
                        }
                    } while (i <= Num);

                    Console.WriteLine();
                    Thread.Sleep(2500);
                    Console.Clear();
                    break;



                case 2:
                    Console.WriteLine("Executando o ex2");
                    int Nume;
                    Console.WriteLine("digite um número para contarmos os números pares até ele até ele:");
                    Nume = int.Parse(Console.ReadLine());
                    i = 1;
                    do
                    {
                        {
                            if (i == 1 || i % 2 == 0)
                                Console.WriteLine(i);
                            i++;
                        }
                    } while (i <= Nume);
                    Console.WriteLine();
                    Thread.Sleep(2500);
                    Console.Clear();
                    break;



                case 3:
                    Console.WriteLine("Executando o ex3");
                    int Numer;
                    int con = 1000;
                    Console.WriteLine("digite um número(menor que mil) para contarmos os números pares de mil até ele:");
                    Numer = int.Parse(Console.ReadLine());
                    if (Numer <= 1000)
                    {
                        do
                        {
                            if (con == 1000 || con % 2 == 0)
                                Console.WriteLine(con);
                            con--;
                        }
                        while (con > Numer);
                    }
                    else
                    {
                        Console.WriteLine("O número é maior que mil");
                    }
                    Thread.Sleep(2500);
                    Console.Clear();
                    break;

                case 4:
                    
                    int valor = 0, Num1;
                    i = 0;
                    do
                    {
                        {
                            Console.WriteLine("Digite números aleatótios para somarmos:");
                            Num1 = int.Parse(Console.ReadLine());
                            valor += Num1;
                            i++;
                            if (Num1 >= 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Último número positivo digitado:{0}", Num1);
                                Console.WriteLine("A soma dos números até agora é de:{0}", valor);
                                Console.WriteLine();
                            }
                            else if (Num1 < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Último número negativo digitado:{0}", Num1);
                                Console.WriteLine("A soma dos números até agora é de:{0}", valor);
                                Console.WriteLine();
                            }
                            
                        }
                    } while (valor <= 200);
                    Thread.Sleep(2500);
                    Console.Clear();
                    break;

                case 5:

                    int Num2;
                    do
                    {
                        Console.WriteLine("Digite um número para que possamos descobrir seus divisores exatos:");
                        Num2 = int.Parse(Console.ReadLine());
                    } while (Num2 <= 0);
                    i = 1;
                    do
                    {
                        {
                            i++;
                            if (Num2 % i == 0)
                            {
                                Console.WriteLine("Os divisores exatos do número escolhido são:{0}", i);
                            }
                        }
                    } while (i <= Num2);
                    Thread.Sleep(2500);
                    Console.Clear();
                    break;

                    case 6:
                    int[] numeros = new int[10];
                    int maior, menor;

                    i = 0;
                    do
                    {
                        {
                            Console.Write($"Digite o {i + 1}º número: ");
                            numeros[i] = int.Parse(Console.ReadLine());
                            i++;
                        }
                    } while (i < 10);
                    maior = menor = numeros[0];
                    i = 1;
                    do
                    {
                        {
                            if (numeros[i] > maior)
                            {
                                maior = numeros[i];
                            }
                            if (numeros[i] < menor)
                            {
                                menor = numeros[i];
                            }
                            i++;
                        }
                    } while (i < 10);
                            Console.WriteLine($"O maior número digitado é: {maior}");
                    Console.WriteLine($"O menor número digitado é: {menor}");
                    Thread.Sleep(2500);
                    Console.Clear();
                    break;

                    case 7:

                    int numero;
                    int Pares = 0;
                    int Impar = 0;

                    Console.Clear();
                    Console.WriteLine("Digite uma sequência de números (digite 0 para parar)");
                    do
                    {
                        Console.Write("Número: ");
                        numero = int.Parse(Console.ReadLine());
                        if (numero != 0)
                        {
                            if (numero % 2 == 0)
                            {
                                Pares += numero;
                            }
                            else
                            {
                                Impar += numero;
                            }
                        }
                    } while (numero != 0);
                    Console.WriteLine($"A soma dos números pares é: {Pares}");
                    Console.WriteLine($"A soma dos números ímpares é: {Impar}");
                    Thread.Sleep(2500);
                    Console.Clear();
                    break;

            }

        }while (opcao != 0);

         
            
       
            
         /*   
        //segundo execício
        
       
        //Terceiro execício
        
        Thread.Sleep(2000);
        Console.Clear();
        //Quarto execício
        
        Thread.Sleep(2000);
        Console.Clear();
        //Quinto execício
       
        Thread.Sleep(2000);
        Console.Clear();
        Console.Clear();
        
        //Sexto execício

        


        Thread.Sleep(3000);
        Console.Clear();



        //Sétimo execício
        
   */
        }
}