Console.Write("Uma distância em metros: ");

float metros = float.Parse(Console.ReadLine() ?? string.Empty);
float km = metros / 1000;
float hm = metros / 100;
float dam = metros / 10;
float dm = metros * 10;
float cm = metros * 100;
float mm = metros * 1000;

Console.WriteLine($"A medida de {metros:1F}m corresponde a\n{km}\n{hm}\n{dam}\n{dm}\n{cm}\n{mm}");