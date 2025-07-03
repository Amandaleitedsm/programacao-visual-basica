/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 26/02/2025
* Autores do Projeto: Amanda Leite de Souza Machado
*                     
* Turma: 2I
* Atividade Proposta em aula
* Observação: <colocar se houver>
* 
* Exercicio5.cs
* ************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1bimestre
{
    class Exercicio5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números primos de 1 a 100:");
            for (int i = 1; i <= 100; i++)
            {
                int primo = 0;
                for (int p = 1; p <= i; p++)
                {
                    if (i%p == 0)
                    {
                        primo++; 
                    }
                }
                if (primo <= 2)
                {
                    Console.WriteLine(i + " é primo.");
                }
            }
        }
    }
}
