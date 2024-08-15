using System;
using Aula02RH.Models;
using Aula02RH.Models.Enuns;

//Comentário 14/08/2024

namespace Aula02RH // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
             Funcionario func = new Funcionario();

            Console.WriteLine("Digite o Id do funcionário: ");
            func.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do funcionário: ");
            func.Nome = Console.ReadLine();
            
            Console.WriteLine("Digite o CPF: ");
            func.Cpf = Console.ReadLine();

            Console.WriteLine("Digite a data de Admissão: ");
            func.DataAdmissao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Salário: ");
            func.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Escolha o tipo de Funcionário (1 - CLT / 2 - Aprendiz): ");
            int opcao = int.Parse(Console.ReadLine());

            //Operador Ternário - Interpretação: Se a condição do parenteses for verdadeira,
            //escolhe o que está depois da "?", Caso contrário, escolhe o que está de pois dos ":"
            func.TipoFuncionario = (opcao == 1) ? TipoFuncionarioEnum.CLT : TipoFuncionarioEnum.Aprendiz;

            func.ReajustarSalario();  
            decimal valorDescontoVT = func.CalcularDescontoVT(6);  

            Console.WriteLine("====================================================================");
            Console.WriteLine($"O salário reajustado é {func.Salario}");
            Console.WriteLine($"O desconto do VT é {valorDescontoVT}");
            Console.WriteLine("====================================================================");

            //Atualização do código na branch de teste    

        }
    }
}