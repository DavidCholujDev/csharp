Console.WriteLine("Zadaj cislo 1");
string number1 = Console.ReadLine();
decimal cislo1 = decimal.Parse(number1);
Console.WriteLine("Zadaj operaciu");
string operacia = Console.ReadLine();
Console.WriteLine("Zadaj cislo 2");
string number2 = Console.ReadLine();
decimal cislo2 = decimal.Parse(number2);

if (operacia == "+")
{
    decimal vysledok = (cislo1 + cislo2);
    Console.WriteLine($"vysledok je {vysledok}");
}

else if (operacia == "-")
{
    decimal vysledok = (cislo1 - cislo2);
    Console.WriteLine($"vysledok je {vysledok}");
}

else if (operacia == "*")
{
    decimal vysledok =(cislo1 * cislo2);
    Console.WriteLine($"vysledok je {vysledok}");
}

else if(operacia == "/")
{
    decimal vysledok =(cislo1 / cislo2);
    Console.WriteLine($"vysledok je {vysledok}");
}

else if  (operacia == "%")
{
    decimal vysledok = (cislo1 % cislo2);
    Console.WriteLine($"zvysek je {vysledok}");
}
Console.WriteLine("dakujem ze si pouzil moju kalkulacku, dovidenia");