const int TAMANHO_ALUNOS = 3;
float[] n1 = new float[TAMANHO_ALUNOS]; 
float[] n2 = new float[TAMANHO_ALUNOS]; 
float[] n3 = new float[TAMANHO_ALUNOS]; 
float[] n4 = new float[TAMANHO_ALUNOS]; 
float[] media = new float[TAMANHO_ALUNOS];
string[] nome = new string[TAMANHO_ALUNOS];

for (int i = 0; i < TAMANHO_ALUNOS; i++)
{
    Console.Write("Informe o Nome: ");
    nome[i] = Console.ReadLine() ?? string.Empty;

    Console.Write($"Informe a Nota 1: ");
    n1[i] = float.Parse(Console.ReadLine() ?? string.Empty);
    
    Console.Write($"Informe a Nota 2: ");
    n2[i] = float.Parse(Console.ReadLine() ?? string.Empty);

    Console.Write($"Informe a Nota 3: ");
    n3[i] = float.Parse(Console.ReadLine() ?? string.Empty);
    
    Console.Write($"Informe a Nota 4: ");
    n4[i] = float.Parse(Console.ReadLine() ?? string.Empty);

    media[i] = (n1[i] + n2[i] + n3[i] + n4[i]) / 4;
    Console.Clear();
}


for (int i = 0; i < TAMANHO_ALUNOS; i++)
{
    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
    Console.WriteLine($"Aluno: {nome[i]}");
    Console.WriteLine($"nota 1: {n1[i]}");
    Console.WriteLine($"nota 2: {n2[i]}");
    Console.WriteLine($"nota 3: {n3[i]}");
    Console.WriteLine($"nota 4: {n4[i]}");
    Console.WriteLine($"Média: {media[i]}");
    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
}