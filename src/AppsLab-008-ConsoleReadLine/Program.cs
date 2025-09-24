Console.WriteLine("Ako sa ty voláš");
string? meno = Console.ReadLine();
Console.WriteLine("Ahoj, " + meno + " Koľko máš rokov");

string vstup = Console.ReadLine() ?? "0";
int vek = int.Parse(vstup);
Console.WriteLine("Aha,máš teda " + vek + " rokov.");

Console.WriteLine("Jake je tvoje oblubene jedlo?");
string? jedlo = Console.ReadLine();
Console.WriteLine("Hmm " + jedlo + "znie skvelo!!");