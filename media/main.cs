using System;

class MainClass {
  public static float MediaVet(float[] vet){
    float soma = 0f;
    for(int i = 0; i < 4; i++)
    {
      Console.Write("{0}, ",vet[i]);
      soma += vet[i];
    }
    float media = soma/4f;
    return media;
  }

  public static void Main (string[] args) {
    float [] vet_coordenadas = new float[4]{2.3f, 0f, 4.5f, 5.6f};
    float media = MediaVet(vet_coordenadas);
    Console.WriteLine("\n\nMedia = {0}" ,media);
  }
}