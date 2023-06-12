using System.ComponentModel.Design;

var imię = "Ewa";
var płeć = "kobieta";
var wiek = 20;

if (płeć == "kobieta")
{
    if (imię == "Ewa" && wiek == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else if (wiek < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else
    {
        Console.WriteLine("Kobieta 30 lat wzwyż");
    }
}
else
{
    if (wiek < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
    else
    {
        if (imię == "Tomasz")
            {
               if (wiek >= 30)
               {
                 Console.WriteLine("Tomasz, 30 lat wzwyż");
               }
              else
               {
                 Console.WriteLine("Tomasz, mniej niż 30 lat");
               }
            }
        else
        {
            Console.WriteLine("Pełnoletni mężczyzna");
        }
    }
}

    

