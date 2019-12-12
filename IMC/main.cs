using System;

class MainClass {
  public static void Main (string[] args) {
    string nome = "", classificacao = "";
    float peso = 0f, altura = 0f;

    while(nome != "sair")
    {
      Console.WriteLine ("Informe os valores para nome, peso e altura:");
      nome = Console.ReadLine();
      if (nome == "sair")
      {
        break;
      }
      //Console.WriteLine ("Informe peso");
      peso = float.Parse(Console.ReadLine());
      //Console.WriteLine ("Informe altura");
      altura = float.Parse(Console.ReadLine());
      float IMC = peso/(altura*altura);

      if (IMC >= 18.5 && IMC < 25)
      {
        classificacao = "saudável";
      }
      else if (IMC >= 25 && IMC < 30)
      {
        classificacao = "sobrepeso";
      }
      else if (IMC >= 30 && IMC < 35)
      {
        classificacao = "obesidade Grau I";
      }
      else if (IMC >= 35 && IMC < 40)
      {
        classificacao = "obesidade Grau II";
      }
  
  
      float pesoIdealMin = 18.5f * (altura * altura);
      float pesoIdealMax = 24.99f * (altura*altura); 
      Console.WriteLine("Olá {0}, o seu IMC calculado foi: {1} \nVocê está {2} \n", nome, IMC, classificacao);
     Console.WriteLine("Seu peso ideal está entre {0} e {1}\n", pesoIdealMin, pesoIdealMax);
    }
  }
}