string number1 = Console.ReadLine();
decimal cislo1 = Convert.ToDecimal(number1);
string operation = Console.ReadLine();
string number2 = Console.ReadLine();
decimal cislo2 = Convert.ToDecimal(number2);

// scitovanie

if (operation == +)
{
    odpoved = cislo1 + cislo2;
    Console.WriteLine($"vysledok je {odpoved}")
}
// odcitanie

else if (operation == -)
{
    odpoved = cislo1 - cislo2;
    Console.WriteLine(odpoved);

}

// nasobenie

else if (operation == *)
{
    odpoved = cislo1 * cislo2;
    Console.WriteLine(odpoved);

}

// delenie
else if (operation == "/")
{
    odpoved = (cislo1 / cislo2);
    Console.WriteLine(odpoved);

}