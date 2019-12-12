using System;

namespace widgets
{
  class PopUp : Janela {
    public bool BotaoOk{get; set;};
    public bool BotaoCancel{get; set;};
   
    public PopUp() : base (){
      BotaoOk = true;
      BotaoCancel = true;
      BotaoFechar = false;
      BotaoMax = false;
      BotaoMin = false;
      Titulo = "Nova PopUp";
      PosX = 0;
      PosY = 0;
    }

    public PopUp(bool Fechar, bool Maximizar, bool Minimizar, string titulo, int x, int y, bool Ok, bool Cancel) : base(Fechar, Maximizar, Minimizar, titulo, x, y) {
      BotaoOk = Ok;
      BotaoCancel = Cancel;
    }


    public PopUp(string titulo, int x, int y, bool Ok, bool Cancel) 
    : base(titulo, x, y) {
      BotaoOk = Ok;
      BotaoCancel = Cancel;
    }
  }
}