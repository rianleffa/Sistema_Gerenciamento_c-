public class FuncionarioTempoIntegral:Funcionario, IBonus
{
    public double SalarioMensal;

    public FuncionarioTempoIntegral(string nome, int matricula, double salario_mensal) : base(nome, matricula)
    {
        Nome = nome;
        Matricula = matricula;
        SalarioMensal = salario_mensal;
    }

    public override double CalcularSalario()
    {
        return SalarioMensal;
    }

    public override void ExibirInformacoes()
    {
        System.Console.WriteLine("=====================");
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Matrícula: " + Matricula);
        Console.WriteLine("Salário: " + CalcularSalario());
        System.Console.WriteLine("======================");       
    }

    public double CalcularBonus()
    {
        return SalarioMensal * 0.1;
    }

    public override void AdicionarProjeto(string projeto)
    {
        
    }

    public override void AdicionarProjeto(List<string> projetos)
    {
        
    }
}