//Rakendus küsib kasutajalt valida tema sugu
//Rakendus küsib sisetada tema perekonnanime
//Lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt: "Welcome, Mr./Ms. Kasutaja perekonnaimi"

Console.WriteLine("Please select your gener (m/f):");
//char kasutatakse vahemälus sümbolite säilitamiseks
//Andmete salvestamine CPUs: Stack - numbrid, sümbolid, true; Heap - stringid, mille asukoht indekseeritakse ja lisatakse stacki
// Console.ReadLine loeb konsoolist andmeid string (sõne) formaadis

char userGender =Char.Parse(Console.ReadLine()); // Char.Parse teeb sisestuse sümboliks
//Console.WriteLine($"Welcome, {userGender}");

Console.WriteLine("Please enter your first name:");
string userFirstName = Console.ReadLine();

Console.WriteLine("Please enter your last name:");
string userLastName = Console.ReadLine();

//"=" salvestamine; "==" võrdlemine; " kasutatakse sõne; ' kasutatakse sünbolitel
if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userFirstName} {userLastName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{userFirstName} {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome {userFirstName} {userLastName}!");
}

