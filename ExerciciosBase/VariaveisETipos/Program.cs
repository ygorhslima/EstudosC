sbyte n = 6;
byte n2 = 255;
short n3 = 32000;
int n4 = 300000000;
long n5 = 3000000000;
float alturaJogador = 1.70f;
decimal valorMonetario = 500.50m;
double realMonetario = 500.50;
bool casado = false;
char letra = 'A';
string nome = "João";
const string senha = "36Hj@!#e1";
var valor = 500;
object nobject;
nobject = "ola";


int inteiro = 100;
float real = 25.5f;
string valorEmString = "500";
//inteiro = (int) real;
inteiro = int.Parse(valorEmString);


Console.WriteLine($"{n}\n{n2}\n{n3}\n{n4}\n{n5}\n{alturaJogador}\n{valorMonetario}\n{realMonetario}\n{casado}\n{letra}\n{nome}\n{senha}\n{valor}\n{nobject}");

Console.WriteLine(inteiro);