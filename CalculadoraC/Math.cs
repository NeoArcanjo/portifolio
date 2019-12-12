using System;
using System.Text;

static class Math
{
  public static double Soma(double num1, double num2){
    return num1+num2;
  }

  public static double Subtracao(double num1, double num2){
    return num1-num2;
  }

  public static double Multiplicacao(double num1, double num2){
    return num1*num2;
  }

  public static double Divisao(double num1, double num2){
    return num1/num2;
  }

  public static double Potencia(double num1, double num2){
    if(num2==0){
      return 1;
    }
    if(num2==1){
      return num1;
    }
    return num1*Potencia(num1, num2-1);
  }
}