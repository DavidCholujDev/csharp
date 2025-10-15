
//////////string i = ("*");
//////////Console.WriteLine(i);
//////////while (i.Length <= 5)
//////////{

//////////    i = (i + "*");
//////////    Console.WriteLine(i);
//////////};
////////using System.Globalization;

////////int[] number = new int[10] {1,2,3,4,5,6,7,8,9,10};
////////int vysledok = 0;
//////////int i = 0;
//////////while (i <= number.Length)
//////////{
//////////    vysledok += number[i];
//////////    i++;

//////////}
////////Console.WriteLine(vysledok);

////////for(int i = 0; i < number.Length; i++)
////////{
////////   vysledok += number[i];
////////}
////////Console.WriteLine(vysledok);

//////string[] cau = { " zajtra ", " nechcem ", " ist ", " do ", " skoly " };

//////foreach(string s in cau)
//////{
//////    Console.Write( s );
//////}


////List<int> numbers = new List<int>();
////Console.WriteLine("dej mi cislo");
////string vstup = Console.ReadLine();



////while (vstup != "+")
////{
////    numbers.Add(int.Parse(vstup));
////    Console.WriteLine("zadej cislo");
////    vstup = Console.ReadLine();
////}

////Console.WriteLine("vysledek scitana");
////int sucet = 0;
////foreach (int i in numbers)
////{
////    sucet += i;
////}
////Console.WriteLine(sucet);


////Console.WriteLine("povedz mi tvoje meno");
////string name = Console.ReadLine();
////Console.WriteLine("vek prosim");
////var vek = Console.ReadLine();
////Console.WriteLine($"Nazdar {name} a mas {vek} rokov");

//string name = ZiskajMeno();
//string vek = ZiskatVek();
//VypisUdaj(name, vek);

//string ZiskajMeno()
//{
//    Console.WriteLine("povedz mi tvoje meno");
//    string name = Console.ReadLine();
//    return name;
//}

//string ZiskatVek()
//{
//    Console.WriteLine("zadaj vek");
//    string vek = Console.ReadLine();
//    return vek;
//}
//void VypisUdaj(string meno, vek);
//{
//    Console.WriteLine($"caves {name}. Tvoj vek je {vek} rokov");
//}
