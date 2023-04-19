//Napisz w Program.cs kod, w ktrórym: 
//    -zadeklarujesz zmienną z imieniam, 
//    -zaeklarujesz zmienną z płacią (dobierz zmienną),
//    -zaeklarujesz zmienną z wiekiem,
//    -zwerifikujesz dane i wyślietlisz
//    // jesten z kominikatówL 
//    (1): "Kobieta poniżej 30 lat"
//    (2): "Ewa, lat 33"
//    (3): "Niepełnoletni Mężczyzna"

//    (Możesz dodać swoje)

var name = "Michał";
var age = 15;
char gender = 'm';

if ((gender == 'k') && (age < 30))
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if ((name == "Ewa") && (age == 33))
{
    Console.WriteLine($"{name}, lat {age}");
}
else if ((age < 18) && (gender == 'm'))
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Osoba nie jest niepełnoletnim mężczyzną, ani Ewą 33 lata, ani kobietą poniżej 30 roku życia.");
}
