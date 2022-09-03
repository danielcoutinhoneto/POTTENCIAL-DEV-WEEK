using System.Collections.Generic;

namespace src.Models;

public class Pessoa
{

  //Construtores
  public Pessoa()
  {
    this.Nome = "template";
    this.Idade = 0;
    this.contratos = new List<Contrato>();
    this.Ativado = true;
  }

  //Construtores
  public Pessoa(string Nome, int Idade, string Cpf)
  {
    this.Nome = Nome;
    this.Idade = Idade;
    this.Cpf = Cpf;
    this.contratos = new List<Contrato>();
    this.Ativado = true;
  }

  //nome, idade, cpf, ativa
  public int Id { get; set; }
  public string Nome { get; set; }
  public int Idade { get; set; }
  public string? Cpf { get; set; } // regra se for um número que vai realizar cálculo coloca como inteiro, caso não seja coloca como string
  public bool Ativado { get; set; }

  public List<Contrato> contratos { get; set; }
}