/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 26/02/2025
* Autores do Projeto: Amanda Leite de Souza Machado
*                     
* Turma: 2I
* Atividade Proposta em aula
* Observação: <colocar se houver>
* 
* Exercicio8.cs
* ************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1bimestre
{
    class Exercicio8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encontre n múltiplos");
            Console.WriteLine("Digite quantos múltiplos você quer receber:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite qual número deve ser multiplicado:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i<=m; i++)
            {
                int mult = n * i;
                Console.WriteLine(n + " x " + i + " = " + mult);
            }
        }
    }
}


