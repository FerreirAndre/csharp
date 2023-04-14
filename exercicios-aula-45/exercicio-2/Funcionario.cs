namespace exercicio
{
  class Funcionario
  {
    public string nome { get; set; }
    public decimal salarioBruto { get; set; }
    public decimal imposto { get; set; }

    public Funcionario(string nome, decimal salarioBruto, decimal imposto)
    {
      this.nome = nome;
      this.salarioBruto = salarioBruto;
      this.imposto = imposto;
    }
    public decimal SalarioLiquido()
    {
      return salarioBruto - imposto;
    }
    public void AumentarSalario(decimal porcentagem)
    {
      salarioBruto += salarioBruto * (porcentagem / 100);
    }
    public override string ToString()
    {
      var retorno = $"Funcionário: {nome}, R$ {SalarioLiquido()}\n";
      return retorno;
    }
  }
}