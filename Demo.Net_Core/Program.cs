using Demo.Net_Core.Models;

//Console.WriteLine("Hello, World!");
//Personne p = new();
//Personne personne = new Personne()
//{
//    FirstName = "Seb",
//    LastName = "Bya",
//    Date = new DateTime(1991, 3, 27),
//    Genre = Genres.Homme
//};
//personne.FirstName = "Seb";
//personne.LastName = "Bya";
//personne.Date = new DateTime(1991, 3, 27);
//personne.Genre = Genres.Homme;

//Guid id = Guid.NewGuid();
//Console.WriteLine(id);

Personnage p = new Personnage()
{
    Name = "Dante",
    Stats = new Stat()
};
p.Stats[StatType.Force] = 10;
Console.WriteLine(p.Stats[StatType.Force]);
Console.WriteLine(p.Stats[StatType.Vitesse]);
