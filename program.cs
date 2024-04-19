using System;

class Program
{
    static void Main(string[] args)
    {
        // Recebe a data atual
        DateTime dataAtual = DateTime.Now;

        // Pede a data de nascimento do usuário
        Console.WriteLine("Digite sua data de nascimento (no formato dd/mm/yyyy):");
        DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

        // Calcula a diferença entre a data atual e a data de nascimento
        TimeSpan diferenca = dataAtual - dataNascimento;

        // Calcula a idade em dias, semanas, meses e anos
        int idadeDias = (int)diferenca.TotalDays;
        int idadeSemanas = (int)(diferenca.TotalDays / 7);
        int idadeMeses = dataAtual.Month - dataNascimento.Month + 12 * (dataAtual.Year - dataNascimento.Year);
        int idadeAnos = dataAtual.Year - dataNascimento.Year;

        // Exibe a idade em dias, semanas, meses e anos
        Console.WriteLine("Idade em dias: " + idadeDias);
        Console.WriteLine("Idade em semanas: " + idadeSemanas);
        Console.WriteLine("Idade em meses: " + idadeMeses);
        Console.WriteLine("Idade em anos: " + idadeAnos);
    }
}
