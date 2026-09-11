
void losowaniePojedyncze()
{

    Console.WriteLine("Losowanie liczby");
    //Wylosuj liczbę z zakresu 1..49

    Random random = new Random();

    int liczba = random.Next(1, 50);
    //Console.WriteLine("wylosowana liczba "+liczba);

    Console.WriteLine("Zgadnij wylosowaną liczbę");



    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("podaj liczbę z zakresu 1..49");
        int zgadywana = int.Parse(Console.ReadLine());
        if (zgadywana == liczba)
        {
            Console.WriteLine("Zgadnięto");
            break;
        }
        if (zgadywana < liczba)
        {
            Console.WriteLine("Wpisano za mało");
        }
        else
        {
            Console.WriteLine("Wpisano za dużo");
        }
    }
}

//losowaniePojedyncze();

void wypisz(int[] tablicaDowypisania)
{
    for (int i = 0; i < tablicaDowypisania.Length; i++)
    {
        Console.Write(tablicaDowypisania[i] + ";");
    }
}

//przeciążanie funkcji wypisz nie działa:( funkcje lokalne nie obsługują przeciążanie
void wypisz2(List<int> listaDoWypisanie)
{
    foreach(int element in listaDoWypisanie)
    {
        Console.WriteLine(element);
    }
}

void wypisz3(HashSet<int> zbiorDoWypisanie)
{
    foreach (int element in zbiorDoWypisanie)
    {
        Console.WriteLine(element);
    }
}

void wylosujKilkaLiczb(int ileLiczb)
{
    int[] liczbyLosowe = new int[ileLiczb];
    //tablice zawsz mają określony rozmiar podczas działania
    //programu nie można go zmienić
    Random random = new Random();
    for (int i = 0; i < ileLiczb; i++)
    {
        liczbyLosowe[i] = random.Next(1, 50);
    }

    //wypisywanie testowe
    wypisz(liczbyLosowe);

}
wylosujKilkaLiczb(7);

List<int> wylosujListe(int ileLiczb)
{
    List<int> losowe = new List<int>();
    //kolekcja może mieć zmieniany rozmiar w trakcie działania 
    int liczba;
    Random random = new Random();
    for(int i = 0; i < ileLiczb; i++)
    {
        liczba = random.Next(1,50); //od 1 do 49
        losowe.Add(liczba);
    }
    return losowe;
}

List<int> wylosowaneLiczby = wylosujListe(5);
wypisz2(wylosowaneLiczby);

List<int> losujLiczbyBezPowtorzen(int ileLiczb)
{
    List<int> listaBezPowtorzen = new List<int>();
    Random random = new Random();
    int liczba;
    for(int i = 0; i < ileLiczb; i++)
    {
        liczba = random.Next(1,50);
        while (listaBezPowtorzen.Contains(liczba))
        {
            liczba = random.Next(1,50);
        }
        listaBezPowtorzen.Add(liczba);
    }
    return listaBezPowtorzen;
}

List<int> listaBezPowtorzen = losujLiczbyBezPowtorzen(20);
Console.WriteLine("lista bez powtórzeń");
wypisz2(listaBezPowtorzen);

/*
 * HashSet
 * Set
 * zbiór
 * elementy bez powtórzeń 
 * nie są indeksowane
 */

HashSet<int> wylosujZbior(int ileLiczb)
{
    HashSet<int> zbiorLiczb = new HashSet<int>();
    Random random = new Random();
    int liczba;
    while (zbiorLiczb.Count < ileLiczb)
    {
        liczba = random.Next(1,50);
        zbiorLiczb.Add(liczba);
    }
    return zbiorLiczb;
}

Console.WriteLine("Zbiór liczba:");
wypisz3(wylosujZbior(5));
