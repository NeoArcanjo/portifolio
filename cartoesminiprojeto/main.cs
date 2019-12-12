using System;
using System.Collections.Generic;



class MainClass {
  public static void Main (string[] args) {

    Cartao meuCard = new Cartao(350);
    Maquina maquininha = new Maquina("CINEMA");
    
    if (maquininha.inserirCartao(45, meuCard)){
      Console.WriteLine("COMPRA REALIZADA");
    }
    else{
      Console.WriteLine("COMPRA NEGADA");
    }
  
    
   

  }
}

//https://www.youtube.com/watch?v=v51ljZ39AHA

//https://www.google.com/search?q=desenvolvendo+aplica%C3%A7%C3%B5es+c%23+com+jetbrains+rider&rlz=1C1GCEA_enBR831BR831&oq=desenvolvendo+aplica%C3%A7%C3%B5es+c%23+com+jetbrains+rider&aqs=chrome..69i57.19255j0j4&sourceid=chrome&ie=UTF-8


