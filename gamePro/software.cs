using System;
using System.Collections.Generic;

namespace GamePro{
  public abstract class SoftwareInterno {
    private string Nome;
    private string Descricao;
    protected int Tamanho;

    public abstract string Sinopse();

    public SoftwareInterno(string Nome, string Descricao, int Tamanho) {
    }
  }
}
