using System;

namespace Aula09;

public class Pessoa(
    string nome, 
    int idade, 
    string sexo
){
    public string Nome = nome;
    public int Idade = idade;
    public string Sexo = sexo;
    public void FazerAniver(){Idade++;}
}
