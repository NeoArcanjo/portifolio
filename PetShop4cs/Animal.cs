using System;

class Animal{
  private string _nome;
  private Date _nascimento;
  private float _peso;

  public Animal(string nome, string dataNascimento, float peso){
    _nome = nome;
    _nascimento = dataNascimento;
    _peso = peso;
  }

  public Animal(string dataNascimento, float peso){
    _nascimento = dataNascimento;
    _peso = peso;
  }

  public Animal(){
    _nascimento = Date.Now();
    _peso = 1.0;
  }

  public int Idade(){
    int anos = DateTime.Now.Year - _nascimento.Year;

    if (DateTime.Now.Month < _nascimento.Month || (DateTime.Now.Month == _nascimento.Month && DateTime.Now.Day < _nascimento.Day))
    {
      anos--;
    }
    return anos; 
  }

  public string Nome{
    get =>  _nome; 
    set{
      _nome = value;
    }
  }
}