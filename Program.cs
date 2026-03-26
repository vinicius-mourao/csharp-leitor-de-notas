using System;

class Program
{
  // Método responsável por ler os nomes e notas dos alunos
    static void LerNotas(string[] nome, double[,] nota, int quantidadeAlunos, int quantidadeNotas) {
        // Percorre todos os alunos
        for (int i = 0; i < quantidadeAlunos; i++) {
            Console.Write($"Nome do {i+1}º aluno: ");
            // Lê o nome digitado pelo usuário com validação
            string? input = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input)){
              Console.Write("Digite um nome válido: ");
              input = Console.ReadLine();
            }

            // Armazena o nome no array
            nome[i] = input;

            // Loop para ler as notas de cada aluno
            for (int j = 0; j < quantidadeNotas; j++) {
                Console.Write($"{j+1}ª nota do {nome[i]}: ");
                double valor;
                // Tenta converter o valor digitado para número (double)
                // Se falhar, pede novamente
                while (!double.TryParse(Console.ReadLine(), out valor)){
                  Console.Write("Digite um valor válido: ");
                }
                // Armazena a nota na matriz
                nota[i,j] = valor;
            }
        }
    }
    // Método responsável por mostrar os dados dos alunos
    static void MostrarNotas(string[] nome, double[,] nota, int quantidadeAlunos, int quantidadeNotas){

          Console.WriteLine("------Resultados------");

          // Percorre todos os alunos
          for (int i = 0; i<quantidadeAlunos; i++){
             // Mostra o nome e as notas do aluno
            Console.WriteLine($"Aluno: {nome[i]}");
            for (int j = 0; j<quantidadeNotas; j++){
              Console.WriteLine($"{j+1}ª nota do aluno: {nota[i,j]}");
            }
          }
        }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Quantos alunos?");
        int quantidadeAlunos;

        // Valida a entrada para garantir que seja um número inteiro positivo
        while (!int.TryParse(Console.ReadLine(), out quantidadeAlunos) || quantidadeAlunos <= 0){
          Console.Write("Digite um número inteiro válido: ");
        }

        // Define que cada aluno terá 2 notas
        int quantidadeNotas = 2;

        // Cria um array para armazenar os nomes dos alunos e uma matriz para as notas
        string[] nome = new string[quantidadeAlunos];
        double[,] nota = new double[quantidadeAlunos, quantidadeNotas];

        // Chama o método para ler os dados
        LerNotas(nome, nota, quantidadeAlunos, quantidadeNotas);

         // Chama o método para exibir os dados
        MostrarNotas(nome, nota, quantidadeAlunos, quantidadeNotas);
    }
}