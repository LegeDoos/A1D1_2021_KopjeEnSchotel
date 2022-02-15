// See https://aka.ms/new-console-template for more information
using KopjeEnSchotel;

Console.WriteLine("A1D1 DC Week 2 oefening!");

Kop mijnKopje = new Kop("Wit", false, true, "Koffie", 0);
Schotel mijnSchotel = new Schotel("Wit", false, "Onder het kopje");
mijnKopje.schotel = mijnSchotel;
mijnSchotel.kop = mijnKopje;

mijnKopje.Vullen(100);
mijnKopje.Vullen(100);
mijnKopje.Vullen(100);

Console.WriteLine($"De inhoud van mijn kopje is {mijnKopje.Hoeveelheid}");
mijnKopje.Hoeveelheid = 1000;

//mijnKopje.hoeveelheid = 1000;
//Console.WriteLine($"De inhoud van mijn kopje is {mijnKopje.hoeveelheid}");


/*
Kop mijnAndereKopje = new Kop("Wit", false, true, "Koffie", 150);
Schotel mijnAndereSchotel = new Schotel("Wit", false, "Onder het kopje");
*/