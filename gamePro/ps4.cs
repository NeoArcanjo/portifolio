using System;
using System.Collections.Generic;

namespace GamePro{
  public class PlayStation4 : VideoGame {
    public override int MemoriaDisponivel(){
        return 1;
    }

    public PlayStation4(string LocalFabricacao, int NumeroSerie, int MemoriaInterna, List <Jogo> jogos): base(LocalFabricacao, NumeroSerie, MemoriaInterna, jogos) {
    }
  }
}