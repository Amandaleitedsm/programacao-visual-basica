/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 26/03/2025
* Autores do Projeto: Amanda Leite de Souza Machado
*                     Yure Campos Camilo
* Turma: 2I
* Projeto 1° Bimestre
* 
* fabrica_brinquedos.cs
* ************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programa1bimestre
{
    class fabrica_brinquedos
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------- Fábrica de brinquedos -------------\n" +
                "------ Otimização da produção de brinquedos ------\n" +
                "--------------------------------------------------------------------");
            string validacao = "s";
            while (validacao == "s")
            {
                bool resposta = false;
                bool i = true;
                Console.WriteLine("\nDigite o tipo de brinquedo: Carrinho / Boneca\n" +
                    "obs: Digite a palavra referente ao tipo de brinquedo");
                
                string escolha = Console.ReadLine();
                
                if (escolha == "Carrinho")
                {
                    Console.WriteLine("\nProduto válido! Produto escolhido: Carrinho");
                    while (i == true)
                    {
                        Console.WriteLine("Digite o número para cálculo do fatorial:");
                        int fatorialCarrinho = int.Parse(Console.ReadLine());
                        if (fatorialCarrinho > 0)
                        {   
                            i = false;
                            int fatorial = 1;
                            while (fatorialCarrinho > 1)
                            {
                                fatorial *= fatorialCarrinho;
                                fatorialCarrinho--;
                            }
                            Console.WriteLine("O número de rodas necessárias para o modelo desejado é: " + fatorial);
                        }
                        else
                        {
                            Console.WriteLine("O número digitado é inválido.\n");
                        }
                    }
                }
                else if (escolha == "Boneca") {
                    Console.WriteLine("\nProduto válido! Produto escolhido: Boneca");
                    while (i == true)
                    {
                        Console.WriteLine("Digite o número para fatoração:");
                        int fatoracaoB = int.Parse(Console.ReadLine());
                        if (fatoracaoB <= 0)
                        {
                            Console.WriteLine("O número digitado é inválido. Digite novamente.");
                        }
                        else
                        {
                            Console.WriteLine("O número de peças de roupa determinado pelos fatores primos do número "
                                        + fatoracaoB + " para este modelo é:");
                            int num = 2;
                            while (num <= fatoracaoB)
                            {
                                int numprimo = 1;
                                int primo = 0;
                                while (numprimo <= num)
                                {
                                    if (num % numprimo == 0)
                                    {
                                        primo++;
                                    }
                                    numprimo++;
                                }
                                if (primo == 2 && fatoracaoB % num == 0)
                                {
                                    Console.Write(num + " ");
                                    fatoracaoB /= num;
                                }
                                else
                                {
                                    num++;
                                }
                            }
                            i = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Produto inválido. Digite 'Carrinho' ou 'Boneca'");
                }
                while (resposta == false && (escolha == "Carrinho" || escolha == "Boneca"))
                {
                    Console.WriteLine("\nDeseja realizar o cálculo para mais algum brinquedo? s / n");
                    validacao = Console.ReadLine();
                    if (validacao == "s" || validacao == "n")
                    {
                        resposta = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida. Insira 's' ou 'n' como resposta");
                    }
                }
            }
            Console.WriteLine("Você escolheu não continuar. Programa encerrado");
        }
    }
}


