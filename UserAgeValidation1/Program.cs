// Rakendus küsib kasutajal sisestada tema vanus
//Kui kasutaja vanus on väiksem kui 13, siis konsoolist kuvatakse "You are too young to use this program"
// Muul juhul konsoolis kuvatakse "Welcome to program"
// int - kasutatakse arvude puhul


using System.ComponentModel.Design;

Console.WriteLine("Enter you age:");

string userAge = Console.ReadLine(); // kasutaja vanus on hetkel string formaadis ehk sõne

int userAgeNum = 0; // vaikimisi väärtus

//boolean - true/false väärtused

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum); // kui sisend on number siis tulemus on true ja salvestab selle numbrina

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if(isAgeNumber) // (isAgeNumber == true) pole vaja lisada kuna kontrollib kas on true/false nagunii
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to program!");
            }
    else
    {
        Console.WriteLine("You are too young to use this program");
    }
}
else
{
    Console.WriteLine("Could not read you age");
}