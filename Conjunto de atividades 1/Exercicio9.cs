/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 26/02/2025
* Autores do Projeto: Amanda Leite de Souza Machado
*                     
* Turma: 2I
* Atividade Proposta em aula
* Observação: <colocar se houver>
* 
* Exercicio9.cs
* ************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1bimestre
{
    class Exercicio9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversão de temperatura");
            Console.WriteLine("Celsius para Fahrenheit: digite '1'\n" +
                "Fahrenheit para Celsius: digite '2'");
            int escolha = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite qual a temperatura:");
            int temp = int.Parse(Console.ReadLine());
            if (escolha == 1)
            {
                float fah = (9.0f * temp + 160) / 5.0f;
                Console.WriteLine("Temperatura em graus Fahrenheit = " + fah+"°F");
            }
            if (escolha == 2)
            {
                float cel = (temp-32)*(5.0f/9.0f);
                Console.WriteLine("Temperatura em graus Celsius = " + cel +"°C");
            }
        }
    }
}



