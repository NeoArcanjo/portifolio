using System ;
using System.IO;
using System.Collections.Generic;

  class Cartao {
    private bool bloqueado;
    private double limite;
    private double [,] faturas;
    private List<double> compras;
    private List<string> estab;
    //construtor

    public Cartao (double l) {
      bloqueado = false;
      compras = new List<double>();// cria a lista
      estab = new List<string>();
      limite = l;
      
    }

    public void senha (string Senha){
      var file = File.Open("senha.tsv", FileMode.Open);
      var reader = new StreamReader(file);
      var linha = reader.ReadLine();
      string senha;
      while(linha != null){
        senha = linha.s
        linha = reader.ReadLine();
      }
      
    }

    public bool comprar (double valor, string e){
      senha("rafael");
      if ((limite-valor >= 0) && bloqueado==false){
        limite = limite - valor;
        compras.Add(valor);
        estab.Add(e);
        return true;
      }
      else {
        return false;
      }
      
      //list :  coleção com tipos de dados
            
    } 
    public double getFatura(){
      double soma = 0;
      bloqueado = true;
      foreach(double v in compras){
        soma = soma + v;
      }
      return soma;
    }
    //criado abaixo o metodo que:
    //bloqueia o cartao
    //soma as compras feitas
    //exibe o total da fatura
    public double fecharFatura(){
      double soma = 0;
      bloqueado = true;
      foreach (double v in compras){
        soma = soma + v;
      }
      return soma;
    }
   //implementado um metodo que:
    //reestabeleca o limite do cartao
    //desbloqueie o cartao
    //exibir confirmacao de pagamento
    // salvar a fatura atual
    public bool pagarFatura(){
      //TODO: SALVAR A FATURA
      StreamWriter saida;
      saida = File.AppendText("faturas.txt");
      //foreach (int i in compras.Count)
      for(int i=0;i<compras.Count;i++)
      {
        saida.WriteLine("{0}:{1}",estab[i], compras[i]);
      }
      saida.Close();
      
      bloqueado=false;
      limite= limite + getFatura(); 
      //HACK LIMPAR LISTAS 
      //idx = compras.Count;
     //for(int i=compras.Count-1;i>=0;i--){
      while(compras.Count > 0){
       compras.RemoveAt(0);
       estab.RemoveAt(0);
     }
      return true;
      //TODO: implementar THY CATCH
    }
    



    // ve a fatura com valor, mes a mes   
    public void ver_fatura(){

      foreach(double v in compras){
        Console.WriteLine(v);
      }
    }

  }

//https://stackoverflow.com/questions/3497699/csv-to-object-model-mapping
//