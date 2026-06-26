
using Aula07_08;

var l = new List<Lutador>
{
    new("Pretty Boy", "França", 31, 1.75f, 68.9f, 11, 2, 1),
    new("Putscript", "Brasil", 29, 1.68f, 57.8f, 14, 2, 3),
    new("DeadCode", "Austrália", 28, 1.93f, 81.6f, 13, 0, 2),
    new("UFOCobol", "Brasil", 37, 1.70f, 119.3f, 5, 4, 3),
    new("Nerdaart", "EUA", 30, 1.81f, 105.7f, 12, 2, 4),
    new("SnapShadow", "Brasil", 35, 1.65f, 80.9f, 12, 2, 1)
};

Luta UEC01 = new Luta();
UEC01.MarcarLuta(l[0], l[1]);
UEC01.Lutar();

l[0].Status();
l[1].Status();