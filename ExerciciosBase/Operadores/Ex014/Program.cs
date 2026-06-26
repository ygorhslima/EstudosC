Console.Write("Informe a temperatura em °C: ");
double temperaturaCelsius = double.Parse(Console.ReadLine() ?? string.Empty);
double temperatureFahrenheint = temperaturaCelsius * 1.8 + 32;

Console.WriteLine($"A temperatura de {temperaturaCelsius}°C corresponde a {temperatureFahrenheint}°F");