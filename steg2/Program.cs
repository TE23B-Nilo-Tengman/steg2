// 1
List<string> leksaker = ["bil", "docka", "lego", "playmobil", "tåg"];

// 2

for (int i = 0; i < leksaker.Count; i++)
{
    Console.WriteLine(leksaker[i]);
}

// 3
List<string> kompisar = ["Dante", "Jack", "Alexander Bolander", "Alexander inte Bolander", "Nilo"];

// Skapa en integer-array (eller lista) med fem värden mellan 0 och 10.
var värden = new List<int>
{
    0,
    8,
    6,
    4,
    2,
};

// Komplettera for-loopen så att den på varje rad skriver ut något liknande "Pelle ger Barbie betyget 5". Använd dina klasskamraters namn, leksakernas namn och värdena från int-arrayen/listan.
for (int i = 0; i < leksaker.Count; i++)
{
    Console.WriteLine(kompisar[i] + " ger leksaken " + leksaker[i] + " betyget " + värden[i]);
}
// Skapa en tom string-lista som heter "cities".
var cities = new List<string> ();

// Skapa en loop där du varje gång loopen körs hämtar en string från användaren med Console.ReadLine. Lägg till den string du får från användaren till cities-listan. Avbryt loopen om användaren skriver "exit".
string input = "";
Console.WriteLine ("skriv namnet på en stad för att läga in det i cities listan. skriv exit för att sluta loopen");

while (input != "exit") {

    input = Console.ReadLine().ToLower();
    if(input != "exit")
    {
        cities.Add(input);
    }
}
// Skapa en loop som ligger efter den ovanstående. Den här loopen ska skriva ut alla strings som finns sparade i cities-listan.
Console.WriteLine("det här är städerna som du skrev");
for (int i = 0; i < cities.Count; i++)
{
    Console.WriteLine(cities[i]);
}



























Console.ReadLine();

