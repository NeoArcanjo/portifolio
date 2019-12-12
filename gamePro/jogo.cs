using System;
using System.Collections.Generic;

namespace GamePro{
  public class Jogo : SoftwareInterno{
    private int QtdPlayers;
    private string Genero;
    
    public override string Sinopse(){
      Console.WriteLine("Vou criar depois");
    }

    public Jogo(string Nome, string Descricao, int Tamanho, int QtdPlayers, string Genero) 
    : base(Nome, Descricao, Tamanho) {
      QtdPlayers = QtdPlayers;
      Genero = Genero;
    }
  }
}