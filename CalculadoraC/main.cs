using System;

class MainClass {
  public static void Main (string[] args) {
    var soma = Math.Soma(5,7);
    var produto = Math.Multiplicacao(5,7);
    var sub = Math.Subtracao(5,7);
    var div = Math.Divisao(5,7);
    var pow = Math.Potencia(5,3);


    Console.WriteLine (soma);
    Console.WriteLine (produto);
    Console.WriteLine (sub);
    Console.WriteLine (div);
    Console.WriteLine (pow);


  }
}