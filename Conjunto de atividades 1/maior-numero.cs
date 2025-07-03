/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 26/02/2025
* Autores do Projeto: Amanda Leite de Souza Machado
*                     
* Turma: 2I
* Atividade Proposta em aula
* Observação: <colocar se houver>
* 
* maior-numero.cs
* ************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    class MaiorNumero
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encontre o maior número");
            Console.WriteLine("Digite um número:");
            float n = float.Parse(Console.ReadLine());
            Console.WriteLine("Deseja digitar mais algum número?\n1- Sim\n2-Não");
            int i = int.Parse(Console.ReadLine());
            float maior = n;
            while (i == 1)
            {
                Console.WriteLine("Digite um número:");
                n = float.Parse(Console.ReadLine());
                if (n>maior)
                {
                    maior = n;
                }
                Console.WriteLine("Deseja digitar mais algum número?\n1- Sim\n2-Não");
                i = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n\n\nMaior número digitado: " + maior);
        }
    }
}
