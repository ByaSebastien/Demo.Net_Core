using Demo.Net_Core.Models;

Console.WriteLine("Hello, World!");
Personne p = new();
Personne personne = new Personne()
{
    FirstName = "Seb",
    LastName = "Bya",
    Date = new DateTime(1991, 3, 27),
    Genre = Genres.Homme
};
personne.FirstName = "Seb";
personne.LastName = "Bya";
personne.Date = new DateTime(1991, 3, 27);
personne.Genre = Genres.Homme;