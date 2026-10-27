using System;

public class ContaBanco {
    private int numConta;
    private string tipo; // cc = conta corrente cp = conta poupança
    private string dono;
    private float saldo;
    private bool status;

    public ContaBanco(string dono, int numConta) {
        this.dono = dono;
        this.numConta = numConta;
    }
  
    public string ToString() {
        return "ContaBanco{" +
                "numConta=" + numConta +
                ", tipo='" + tipo + '\'' +
                ", dono='" + dono + '\'' +
                ", saldo=" + saldo +
                ", status=" + status +
                '}';
    }

    public void AbrirConta(string tipo){
        this.tipo = tipo;
        status = true;
        if(tipo == "cc"){
            saldo = 50;
            Console.WriteLine($"Olá {dono} Você abriu uma conta corrente ({this.tipo}), você ganhou um incentivo de R${saldo}");
        } else if (this.tipo == "cp"){
            saldo = 150;
            Console.WriteLine($"Olá {dono} Você abriu uma conta poupança ({this.tipo}), você ganhou um incentivo de R${saldo}");
        }else{
            Console.WriteLine("Conta aberta com sucesso");
        }
    }

    public void FecharConta(){
        if(saldo > 0){
            Console.WriteLine("Conta não pode ser fechada pois contém dinheiro ");
        }
        else if (saldo < 0){
            Console.WriteLine("Conta não pode ser fechada pois tem débito");
        }else {
            status = false;
            Console.WriteLine("Conta fechada com sucesso");
        }
    }
    public void Depositar(float valor){
        if(status){
            saldo += valor;
        }
    }
    public void Sacar(float valor){
        if(status){
            if(saldo >= valor){
                saldo -= valor;
                Console.WriteLine($"Saque realizado na conta de {dono}");
            }else{
                Console.WriteLine("Saldo insuficiente para sacar");
            }
        }else{
            Console.WriteLine("Impossível sacar com a conta fechada");
        }
    }

    public void PagarMensal(){
        int v = 0;
        if(tipo == "cc"){
            v = 12;
        }else if (tipo == "cp"){
            v = 20;
        }
        if(status){
            saldo -= v;
            Console.WriteLine($"Mensalidade paga com sucesso por {dono}");
        }else{
            Console.WriteLine("impossível pagar uma conta fechada");
        }
    }
}
