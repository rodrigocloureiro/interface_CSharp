public interface ICadastrarAluno
{
    void AdicionarAluno(Aluno aluno);
    IList<Aluno> ListaAlunos();
}

public class Aluno
{
    public int _matricula { get; set; }
    public string _nome { get; set; }

    public Aluno(int matricula, string nome)
    {
        this._matricula = matricula;
        this._nome = nome;
    }
}

public class CadastrarAlunoEmMemoria : ICadastrarAluno
{
    private IList<Aluno> _listaAluno;

    public CadastrarAlunoEmMemoria()
    {
        _listaAluno = new List<Aluno>();
    }

    public void AdicionarAluno(Aluno aluno)
    {
        _listaAluno.Add(aluno);
    }

    public IList<Aluno> ListaAlunos() { return _listaAluno; }
}

public class Program
{
    public static void Main(string[] args)
    {
        ICadastrarAluno i = new CadastrarAlunoEmMemoria();
        i.AdicionarAluno(new Aluno(1, "Clara"));

        Aluno aluno2 = new Aluno(2, "Rodrigo");
        i.AdicionarAluno(aluno2);

        Aluno aluno3 = new Aluno(3, "Diego");
        i.AdicionarAluno(aluno3);

        //Console.WriteLine(i.ListaAlunos());

        foreach (Aluno aluno in i.ListaAlunos())
        {
            Console.WriteLine($"Nome: {aluno._nome} - Matrícula: {aluno._matricula}");
        }

        Console.ReadKey();
    }
}
