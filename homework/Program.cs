Console.WriteLine("Zadaj cislo 1");
string number1 = Console.ReadLine();
decimal cislo1 = decimal.Parse(number1);
Console.WriteLine("Zadaj operaciu +-/%");
string operacia = Console.ReadLine();
Console.WriteLine("Zadaj cislo 2");
string number2 = Console.ReadLine();
decimal cislo2 = decimal.Parse(number2);

decimal vysledok = 0;
switch (operacia)
{
    case "+":
        vysledok = cislo1 + cislo2;
        Console.WriteLine(vysledok);
        break;
    case "-":
        vysledok = cislo2 - cislo2;
        Console.WriteLine(vysledok);
        break;
    case "/":
        if (cislo2 == 0) 
        {
            Console.WriteLine("ty magor nulou sa neda delit");
        }
        vysledok = cislo1 / cislo2;     
        Console.WriteLine(vysledok);
        break;
    case "*":
        vysledok = cislo1 * cislo2;
        Console.WriteLine(vysledok);
        break;
    case "%":
        vysledok = (cislo1 / cislo2);
        Console.WriteLine(vysledok);
        break;
}

