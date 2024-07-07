using System;
using System.Collections.Generic;

public class Empresa
{
    private List<Funcionario> funcionarios = new List<Funcionario>();

    public void AdicionarFuncionario(Funcionario funcionario)
    {
        funcionarios.Add(funcionario);
    }

    public void RemoverFuncionario(int matricula)
    {
        funcionarios.RemoveAll(f => f.Matricula == matricula);
    }

    public void ExibirFuncionarios()
    {
        foreach (var funcionario in funcionarios)
        {
            funcionario.ExibirInformacoes();
        }
    }

    public void AdicionarProjeto(int matricula, List<string> projetos)
    {
        var funcionario = funcionarios.Find(f => f.Matricula == matricula);
        if (funcionario != null)
        {
            funcionario.AdicionarProjeto(projetos);
        }
        else
        {
            Console.WriteLine("Funcionário não encontrado.");
        }
    }
}
