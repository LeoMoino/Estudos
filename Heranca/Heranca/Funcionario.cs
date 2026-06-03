using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }

        public string Registro { get; set; }
    }

    public class Processo
    {
        public void Execucao()
        {
            var funcionario = new Funcionario
            {
                Nome = "Leonardo Moino",
                DataNascimento = new DateTime(2002, 12, 06),
                DataAdmissao = new DateTime(2020, 01, 01),
                Registro = "01"
            };

            Console.WriteLine($"Nome: {funcionario.Nome}");
            Console.WriteLine($"Data de Nascimento: {funcionario.DataNascimento:dd/MM/yyyy}");
            Console.WriteLine($"Idade: {funcionario.CalcularIdade()} anos");
            Console.WriteLine($"Data de Admissão: {funcionario.DataAdmissao:dd/MM/yyyy}");
            Console.WriteLine($"Registro: {funcionario.Registro}");
        }
    }
}
