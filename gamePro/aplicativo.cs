using System;
using System.Collections.Generic;

namespace GamePro{
  public class Aplicativo : SoftwareInterno {
    private string Versao;

    public override string Sinopse(){
      Console.WriteLine("Vou criar depois");
    }

    public Aplicativo (string Nome, string Descricao, int Tamanho, string Versao) 
    : base(Nome, Descricao, Tamanho) {
      Versao = Versao;
    }
  }
}