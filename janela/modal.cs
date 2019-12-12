using System;

namespace widgets
{
  class Modal : Janela, IDimensional {
    public int MaxAlt{get; set;};
    public int MaxLarg{get; set;};
    public int AtualAlt{get; set;};
    public int AtualLarg{get; set;};
   
    public Modal() : base (){
      MaxAlt = 15;
      MaxLarg = 15;
      AtualAlt = 5;
      AtualLarg = 5;
      BotaoMax = false;
      BotaoMin = false;
      Titulo = "Nova Modal";
    }

    public Modal(string titulo, int x, int y, int atualAlt, int atualLarg) 
    : base(titulo, x, y) {
      MaxAlt = 15;
      MaxLarg = 15;
      AtualAlt = (atualAlt <= MaxAlt) ? atualAlt : MaxAlt;
      AtualLarg = (atualLarg <= MaxLarg) ? atualLarg : MaxLarg;
      BotaoMax = false;
      BotaoMin = false;
    }
  }
}