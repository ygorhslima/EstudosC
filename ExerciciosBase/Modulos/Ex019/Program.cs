Console.Write("Primeiro aluno: ");
string a1 = Console.ReadLine() ?? string.Empty;

Console.Write("Segundo aluno: ");
string a2 = Console.ReadLine() ?? string.Empty;

Console.Write("Terceiro Aluno: ");
string a3 = Console.ReadLine() ?? string.Empty;

Console.Write("Quarto Aluno: ");
string a4 = Console.ReadLine() ?? string.Empty;

string[] ArrAlunos = [a1,a2,a3,a4];

Random rand = new Random();
int escolhido = rand.Next(ArrAlunos.Length);
string alunoSorteado = ArrAlunos[escolhido];

Console.WriteLine($"O aluno escolhido foi {alunoSorteado}");