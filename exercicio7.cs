public static class Exercicio7
{
    public static void Executar()
    {
        double notaProva;
        double notaAtividades;
        double mediaFinal;

        Console.Write("Digite a nota da prova: ");
        notaProva = double.Parse(Console.ReadLine()!);

        Console.Write("Digite a nota das atividades em sala: ");
        notaAtividades = double.Parse(Console.ReadLine()!);

        mediaFinal = ((notaProva * 4) + notaAtividades * 6) / 10;

        Console.WriteLine();
        Console.WriteLine($"A média final do aluno é: {mediaFinal}");
    }
}