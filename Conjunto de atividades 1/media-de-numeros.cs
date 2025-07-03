/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 26/02/2025
* Autores do Projeto: Amanda Leite de Souza Machado
*                     
* Turma: 2I
* Atividade Proposta em aula
* Observação: <colocar se houver>
* 
* media-de-numeros.cs
* ************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    class MediaNumeros
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encontre a média dos números");
            Console.WriteLine("Digite um número:");
            float n = float.Parse(Console.ReadLine());
            Console.WriteLine("Deseja digitar mais algum número?\n1- Sim\n2-Não");
            int i = int.Parse(Console.ReadLine());
            float soma = n;
            int c = 1;
            while (i == 1)
            {
                c++;
                Console.WriteLine("Digite um número:");
                n = float.Parse(Console.ReadLine());
                soma += n;
                Console.WriteLine("Deseja digitar mais algum número?\n1- Sim\n2-Não");
                i = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n\n\nMédia dos números digitados: " + (soma/c));
        }
    }
}

