/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 26/02/2025
* Autores do Projeto: Amanda Leite de Souza Machado
*                     
* Turma: 2I
* Atividade Proposta em aula
* Observação: <colocar se houver>
* 
* Exercicio10.cs
* ************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1bimestre
{
    class Exercicio10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");
            float resp = 0;
            int escolha2 = 1;
            while (escolha2 == 1)
            {
                Console.WriteLine("Escolha a operação matemática:\n" +
                    "Adição = '1'\n" +
                    "Subtração = '2'\n" +
                    "Multiplicação = '3'\n" +
                    "Divisão = '4'");
                int escolha = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o primeiro número:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número:");
                int b = int.Parse(Console.ReadLine());
                if (escolha == 1)
                {
                    resp = a + b;
                }
                if (escolha == 2)
                {
                    resp = a - b;
                }
                if (escolha == 3)
                {
                    resp = a * b;
                }
                if (escolha == 4)
                {
                    resp = a/b;
                }
                Console.WriteLine("Resposta = " + resp);
                Console.WriteLine("\n\nDeseja realizar outra operação?\n1- Sim\n2- Não");
                escolha2 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Calculadora finalizada com sucesso!");
        }
    }
}



