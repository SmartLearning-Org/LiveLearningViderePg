List<string> navne = new();

Console.WriteLine("Indtast nogle navne. Afslut med blank linje.");

bool done = false;
do
{
    string navn = Console.ReadLine();
    if (String.IsNullOrEmpty(navn))
    {
        done = true;
    }
    else
    {
        navne.Add(navn);
    }
} while (!done);

Console.WriteLine("Du har indtastet følgende navne:");

foreach (string navn in navne)
{
    Console.WriteLine(navn);
}