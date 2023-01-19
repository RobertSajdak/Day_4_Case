var id = 1;
var name = "Ewa";
var age = 33;
char sex = 'K'; // K - kobieta, M - mężczyzna

if (sex == 'K') 
{
    if (age >= 0 && age < 30)
        Console.WriteLine("\nJesteś kobietą w wieku poniżej 30 lat.");
    else if (age == 33 && name == "Ewa")
        Console.WriteLine($"\n{name}, lat {age}.");
    else if (age > 30)
        Console.WriteLine($"\nJesteś kobietą po 30-tce.");
}

else if (sex == 'M' && age >= 1 && age < 18)
    Console.WriteLine("\nJesteś niepełnoletnim mężczyzną.");
else
    Console.WriteLine("\nJestaś dorosłym facetem!");