/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 26/02/2025
* Autores do Projeto: Amanda Leite de Souza Machado
*                     
* Turma: 2I
* Atividade Proposta em aula
* Observação: <colocar se houver>
* 
* fatorial.cs
* ************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    class fatorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int n = int.Parse(Console.ReadLine());
            int fat = 1;
            for (int i = 1; i <= n; i++)
            {
                fat *= i;
            }
            Console.WriteLine("Fatorial do número " + n + " = " + fat);
        }
    }
}
