namespace src.Models;

public class Contrato
{

  //Metodo Construtor
  public Contrato()
  {
    this.DataCriacao = DateTime.Now;
    this.valor = 0;
    this.TokenId = "000000";
    this.Pago = false;
  }

  //Metodo Construtor
  public Contrato(string TokenID, double Valor)
  {
    this.DataCriacao = DateTime.Now;
    this.TokenId = TokenID;
    this.valor = Valor;
    this.Pago = false;
  }

  public DateTime DataCriacao { get; set; }
  public string TokenId { get; set; }
  public double valor { get; set; }
  public bool Pago { get; set; }



}