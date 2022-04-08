// See https://aka.ms/new-console-template for more information

using Geometria;

Console.WriteLine("Inserisci la base: ");
int lato = int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci l'altezza: ");
int altezza = int.Parse(Console.ReadLine());
Rettangolo rettangolo = new Rettangolo(lato, altezza);
rettangolo.Stampa(lato,altezza);
int b = 10;
int h = 6;
Rettangolo SecondoRettangolo = new Rettangolo(b, h);
SecondoRettangolo.Stampa(b, h);