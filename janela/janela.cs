using System;

namespace widgets
{
  class Janela {
    public bool BotaoFechar{get; set;};
    public bool BotaoMax{get; set;};
    public bool BotaoMin{get; set;};
    public string Titulo{get; set;};
    public int PosX{get; set;};
    public int PosY{get; set;};

    public virtual void MoverJanela(int x, int y){
      PosX = x;
      PosY = y;
    }

    public Janela(){
      BotaoFechar = true;
      BotaoMax = true;
      BotaoMin = true;
      Titulo = "Nova Janela";
      PosX = 0;
      PosY = 0;
    }

    public Janela(bool Fechar, bool Maximizar, bool Minimizar, string titulo, int x, int y){
      BotaoFechar = Fechar;
      BotaoMax = Maximizar;
      BotaoMin = Minimizar;
      Titulo = titulo;
      PosX = x;
      PosY = y;
    }

    public Janela(string titulo, int x, int y){
      BotaoFechar = true;
      BotaoMax = true;
      BotaoMin = true;
      Titulo = titulo;
      PosX = x;
      PosY = y;
    }
  }
}