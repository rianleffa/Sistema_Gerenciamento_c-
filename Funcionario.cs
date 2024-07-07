public abstract class Funcionario
{
    public string Nome;
    public int Matricula;

    public Funcionario(string nome, int matricula)
    {
        Nome = nome;
        Matricula = matricula;
    }

    public abstract double CalcularSalario();
    public abstract void ExibirInformacoes();
    public abstract void AdicionarProjeto(string projeto);
    public abstract void AdicionarProjeto(List<string> projetos);
}