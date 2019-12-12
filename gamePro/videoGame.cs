using System;
using System.Collections.Generic;

namespace GamePro{
  public abstract class VideoGame {
    private string LocalFabricacao;
    private int NumeroSerie;
    protected int MemoriaInterna;
    public List <Jogo> jogos = new List<Jogo> ();

    public abstract int MemoriaDisponivel();

    public virtual void AdicionarSW(Jogo j){
      jogos.Add(j);
    }
    
    public VideoGame (string LocalFabricacao, int NumeroSerie, int MemoriaInterna, List <Jogo> jogos){
    }
  }
}

