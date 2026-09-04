
Console.WriteLine("Losowanie liczby");
//Wylosuj liczbę z zakresu 1..49

Random random = new Random();

int liczba = random.Next(1,50);
Console.WriteLine("wylosowana liczba "+liczba);
