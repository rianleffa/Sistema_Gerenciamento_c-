public class FuncionarioMeioPeriodo:Funcionario, IBonus
{
    public double SalarioHora;
    public float HorasTrabalhadas;

    public FuncionarioMeioPeriodo(string nome, int matricula, double salario_hora, float horas_trabalhadas):base(nome, matricula)
    {
        Nome = nome;
        Matricula = matricula;
        SalarioHora = salario_hora;
        HorasTrabalhadas = horas_trabalhadas;
    }

    public override double CalcularSalario()
    {
        return SalarioHora * HorasTrabalhadas;
    }

    public override void ExibirInformacoes()
    {
        System.Console.WriteLine("====================");
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Matrícula: " + Matricula);
        Console.WriteLine("Salário: " + CalcularSalario());
        System.Console.WriteLine("====================");
    }

    public double CalcularBonus()
    {
        return CalcularSalario() * 0.05;
    }

    public override void AdicionarProjeto(string projeto)
    {
        
    }

    public override void AdicionarProjeto(List<string> projetos)
    {
        
    }
}