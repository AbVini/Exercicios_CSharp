using System;

class MainClass {
  public static void Main (string[] args) {
    int idade;
    double altura, peso, copiaPeso, IMC;
    string nome;
    bool temCNH;

    idade = 23;
    altura = 1.76;
    peso = 78.9;
    nome = "João da Silva";
    temCNH = true;
    copiaPeso = peso; 
    IMC = peso / (altura * altura);
  }
}