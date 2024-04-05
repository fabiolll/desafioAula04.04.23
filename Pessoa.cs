using System;

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public int Altura { get; set; }

    public Pessoa(string nome, int idade, int altura)
    {
        Nome = nome;
        Idade = idade;
        Altura = altura;
    } 
    public void Apresentar()
    {
       Console.WriteLine($"nome:{Nome}, idade:{Idade}, altura: {Altura}");
    }
}