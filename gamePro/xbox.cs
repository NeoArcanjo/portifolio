using System;
using System.Collections.Generic;

namespace GamePro{
  public class XboxOne : VideoGame {
    private int ArmazenamentoExtra;
    public List<Aplicativo> aplicativos = new List<Aplicativo>();

    public override int MemoriaDisponivel(){
      return 2;
    }

    public override void AdicionarSW(Aplicativo j){
      aplicativos.Add(j);
    }

    /*
    public override void AdicionarSW(Jogo j){
      jogos.Add(j);
    }
    */

    public void ExibirSinopses() {
      Console.WriteLine("Vou criar depois");
    }

    public XboxOne (string LocalFabricacao, int NumeroSerie, int MemoriaInterna, int ArmazenamentoExtra, List <Jogo> jogos, List <Aplicativo> aplicativos)
    : base(LocalFabricacao, NumeroSerie, MemoriaInterna) {
      ArmazenamentoExtra = ArmazenamentoExtra;
      aplicativos = aplicativos;
    }
  }
}