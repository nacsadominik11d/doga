//2.Feladat
Console.WriteLine("Adja meg a Bérlő nevét: ");
string berloneve = Console.ReadLine();
Console.WriteLine("Adja meg a napok számát: ");
int napokszama = int.Parse(Console.ReadLine());
Console.WriteLine("Adja meg hogy VIP tag e a bérlő True vagy False: ");
string viptag = Console.ReadLine();
int napidij = 12000;
int vegosszeg = napokszama * napidij;
int keveskedvezmeny = 5*100 - vegosszeg; ;
int sokkedvezmeny = 15*100 - vegosszeg;
if (napidij >=  7 ) Console.WriteLine($" 15% kedvezményt kapott{sokkedvezmeny} Ft.");
else Console.WriteLine("A Kedvezmény sajnos nem járt! ");

if (napidij < 7)Console.WriteLine($" 5% kedvezményt kapott{keveskedvezmeny} Ft.");
else Console.WriteLine("A Kedvezmény sajnos nem járt!");

if (napidij < 3)Console.WriteLine($"Kedvezmény sajnos nem jár így {vegosszeg} Ft.");

//3.feladat
if (vegosszeg >= 200000) Console.WriteLine("Kiemelkedő forgalmú nap");
else if (vegosszeg >=100000) Console.WriteLine("Átlagos forgalmú nap");
else Console.WriteLine("gyenge forgalmú nap");
