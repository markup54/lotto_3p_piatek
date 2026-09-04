
Console.WriteLine("Losowanie liczby");
//Wylosuj liczbę z zakresu 1..49

Random random = new Random();

int liczba = random.Next(1,50);
//Console.WriteLine("wylosowana liczba "+liczba);

Console.WriteLine("Zgadnij wylosowaną liczbę");

Console.WriteLine("podaj liczbę z zakresu 1..49");
int zgadywana = int.Parse(Console.ReadLine());
if(zgadywana == liczba)
{
    Console.WriteLine("Zgadnięto");
}
else
{
    Console.WriteLine("Może innym razem");
}
