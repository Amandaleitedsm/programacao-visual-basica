/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 26/02/2025
* Autores do Projeto: Amanda Leite de Souza Machado
*                     
* Turma: 2I
* Atividade Proposta em aula
* Observação: <colocar se houver>
* 
* Exercicio1.cs
* ************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1bimestre
{
    class Exercicio1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números pares de 1 a 100");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " é par.");
                }
            }
        }
    }
}
