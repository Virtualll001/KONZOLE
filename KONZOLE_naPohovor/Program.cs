using KONZOLE_naPohovor;

//ZDROJ: https://www.youtube.com/watch?v=-1NUQNSVVmk&list=PL6n9fhu94yhWlAv3hnHzOaMSeggILsZFs&index=2























//12. 
//Pohovorová otázka: "Jaký je modifikátor přístupu defaultního konstruktoru v C#"
//Odpověď: Nevytvoříme-li třídě konstuktor explicitně, má defaultně bezparametrický konstruktor s modifikátorem přístupu Public.
//







////11.
////Pohovorová otázka: "Máme abstraktní třídu s metodou která obsahuje základní implementaci. Někteří potomci 
////potřebují tuto implementaci, ale jiní potřebují jinou..."
////Odpověď: 

//Potomek1 pot1 = new Potomek1();
//Potomek2 pot2 = new Potomek2();
//pot1.CvicnaMetoda();
//pot2.CvicnaMetoda();

//public class Potomek2 : AbstraktniTrida
//{
//    public override void CvicnaMetoda()
//    {
//        //potomek si upravil metodu předka podle své potřeby
//        Console.WriteLine("Jiná implementace...");
//    }
//}
//public class Potomek1 : AbstraktniTrida
//{
//    //potomek má k dispozici Defaultní implementaci svého předka
//}

//public abstract class AbstraktniTrida
//{
//    public virtual void CvicnaMetoda()
//    {
//        Console.WriteLine("Defaultní implementace!");
//    }
//}






////10.
////Pohovorová otázka: "Jak převrátit písmena ve slovech dané věty?"
////Odpověď:
//string inputString = "one two three four five";
//string result = string.Join(' ', inputString.Split(' ').Select(x => new String(x.Reverse().ToArray())));
//Console.WriteLine(result);






////9.
////Pohovorová otázka: "Jaký je rozdíl mezi operátorem přetypování a AS?"
////Odpověď: Při neúspěšné konverzi vyvolá operátor přetypování výjimku, zatímco AS vrátí NULL: 

//Employee emp = new Employee { ID = 101, Name = "Mark" };
//PermanentEmployee permanentEmployee = (PermanentEmployee)emp; //výjimka
//PermanentEmployee permanentEmployee1 = emp as PermanentEmployee; //NULL
//public class Employee
//{
//    public int ID { get; set; }
//    public string Name { get; set; }
//}

//public class PermanentEmployee : Employee
//{

//}



////8.
////Pohovorová otázka: "Dá se zavolat abstraktní metoda z konstruktoru abstraktní třídy?"
////Odpověď: Ano - implementaci abstraktní třídy dodá potomek a při vytváření instance potomka se spustí
////rodičovský konstruktor s metodou jejíž implementaci potomek dodal:
//CorporateCustomer CC = new CorporateCustomer();
//SavingsCustomer SC = new SavingsCustomer();

//public abstract class Customer
//{
//    public Customer()
//    {
//        Print();
//    }
//    public abstract void Print();
//}

//public class CorporateCustomer : Customer
//{
//    public override void Print()
//    {
//        Console.WriteLine("CorporateCustomer PRINT");
//    }
//}

//public class SavingsCustomer : Customer
//{
//    public override void Print()
//    {
//        Console.WriteLine("SavingsCustomer PRINT");
//    }
//}







//7. 
//Pohovorová otázka: "Může mít abstraktní třída konstruktor?"
//Odpověď: Ano - abstraktní třída může mít konstruktor - zpravidla se používá k inicializování vlastností 
//např. ID (this._id = Guid.NewGuid();) má-li dojít k inicializaci před vytvořením instance potomka. Nebo lze takto spustit kód, který
//je relevantní pro všechny potomky.
//Dobrou praktikou je označovat konstruktor abstraktní třídy "protected" ("public" nemá smysl, když sama abstraktní třída konstruktor nevyužije)...






////6.
////Pohovorová otázka: "Je možné uložit různé množství Listů různého typu v jednom generickém listu?"
////Odpověď: Ano - List může obsahovat <List<object>>:

//List<List<object>> list = new List<List<object>>();
//List<object> list2 = new List<object>();
//list2.Add("Mája"); list2.Add("Kája"); list2.Add("Bája"); list2.Add("Ája");
//list.Add(list2);

//List<object> list3 = new List<object>();
//list3.Add(101); list3.Add(150); list3.Add(400);
//list.Add(list3);

//foreach (var item in list)
//{
//    foreach (var polozka in item)
//    {
//        Console.WriteLine(polozka);
//    }
//    Console.WriteLine();
//}






////5.
////Pohovorová otázka: "Co je rekurzivní funkce (+ příklad)?"
////Odpověď: Když metoda volá sama sebe:
//
////*******FAKTORIÁL ZA POMOCI REKURZE***********
//Console.WriteLine("Prosím zadejte číslo: ");
//int number = int.Parse(Console.ReadLine());
//double fact = FaktorialRekurze.FactorialRekurze(number);
//Console.WriteLine($"Faktoriál čísla {number} je: " + fact);
//class FaktorialRekurze
//{
//    public static double FactorialRekurze(int number)
//    {
//        if (number == 0)
//            return 1;
//        return number * FactorialRekurze(number - 1);
//    }
//}
//
////*******FAKTORIÁL BEZ REKURZE***********
//class Faktorial
//{
//    public static double Factorial(int number)
//    {
//        if (number == 0)
//            return 1;
//        double factorial = 1;
//        for (int i = number; i >= 1; i--)
//        {
//            factorial = factorial * i;
//        }
//        return factorial;
//    }
//}
//
////*******FAKTORIÁL příklad 2 REKURZE pro hledání souborů***********
//static void NajdiSoubory(string path)
//{
//    foreach (string fileName in Directory.GetFiles(path))
//    {
//        Console.WriteLine(fileName);
//    }
//    foreach(string directory in Directory.GetDirectories(path))
//    {
//        NajdiSoubory(directory);
//    }
//}
//
//Console.WriteLine("Please enter path: ");
//string cesta = Console.ReadLine();
//NajdiSoubory(cesta);
////C:\Users\lonet\source\repos\KONZOLE





//4.
//Pohovorová otázka: "Kdy a proč použít interfacy?"
//Odpověď:
//1) díky nim vytváříme "loosly coupled" systémy
//2) jsou užitečné pro DI
//3) snadnější testování (unit testing a mocking)






//3.
//Pohovorová otázka: "Kdy a proč použít abstraktní třídu?"
//Odpověď: Když máme dvě a více tříd se stejnou funkcionalitou (vlastnostmi a metodami)
//a chceme se vyhnout duplicitnímu kódu, ohlídat si že odvozené třídy budou mít metody, které mít mají (abstract/override)
//a zároveň daná třída nebude mít vlastní instance. 
//Pokud chceme, aby základní třída měla své instance => řešímě běžným děděním (u metod virtual/override)...






////2.
////Pohovorová otázka: Co je "jagged array". Vypracuj příklad:
////Odpověď: "zubaté pole" (pole polí, 2D pole) pole uvnitř pole:

//string[] uchazeci = new string[] { "Machovská", "Novotný", "Douda" };
//string[][] polePoli = new string[3][];

//polePoli[0] = new string[3] { "střední škola", "bakalář", "doktor" };
//polePoli[1] = new string[1] { "střední škola" };
////delší zápis:
//polePoli[2] = new string[2];
//polePoli[2][0] = "střední škola";
//polePoli[2][1] = "bakalář";

//for (int i = 0; i < polePoli.Length; i++)
//{
//    Console.WriteLine(uchazeci[i]);
//    Console.WriteLine("*********");
//    string[] vnitrniPole = polePoli[i]; //je potřeba vytvořit si 
//    for (int j = 0; j < vnitrniPole.Length; j++)
//    {
//        Console.WriteLine(vnitrniPole[j]);
//    }
//    Console.WriteLine();
//}

//Console.WriteLine("*************************************************");
//Console.WriteLine();

////KRATŠÍ ZÁPIS

//string[] ovoce = { "Jahoda", "Banán", "Hruška" };
//string[][] polePoliZKRATKA = new string[][]{
//    new string[] { "vit. C", "Vit. A", "Vit. E" },
//    new string[] { "draslík", "vápník"},
//    new string[] { "vápník"}
//};

//for (int i = 0; i < polePoliZKRATKA.Length; i++)
//{
//    Console.WriteLine(ovoce[i]);
//    Console.WriteLine("--------");
//    string[] vnitrniPole2 = polePoliZKRATKA[i];
//    for (int j = 0; j < vnitrniPole2.Length; j++)
//    {
//        Console.WriteLine(vnitrniPole2[j]);
//    }
//    Console.WriteLine();
//}





//1.
//Pohovorová otázka: Je možné do pole ukládat různé typy?
//Odpověď ANO. Předkem všech typů je objekt - vytvoříme-li pole objektů, můžeme tam dát cokoliv:
//Viz třída Pole.cs
//Pole pole = new Pole();
//Console.WriteLine(pole);

