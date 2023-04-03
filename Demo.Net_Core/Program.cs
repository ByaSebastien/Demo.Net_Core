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

//Personnage p = new Personnage()
//{
//    Name = "Dante",
//    Stats = new Stat()
//};
//p.Stats[StatType.Force] = 10;
//Console.WriteLine(p.Stats[StatType.Force]);
//Console.WriteLine(p.Stats[StatType.Vitesse]);
//List<string> list = new List<string>() { "a", "b", "d" };
//Console.WriteLine(string.Join(" ", list));

Personne p1 = new Personne()
{
    FirstName = "Seb ",
    LastName = "Bya ",
    Date = new DateTime(1991, 3, 27),
    Genre = Genres.Homme
};
Personne p2 = new Personne()
{
    FirstName = "yanick",
    LastName = "noah",
    Date = new DateTime(1991, 3, 27),
    Genre = Genres.Homme
};
Personne p3 = p2 + p1;
Console.WriteLine($"{p1.FirstName} {p1.LastName}");
Console.WriteLine($"{p2.FirstName} {p2.LastName}");
Console.WriteLine($"{p3.FirstName} {p3.LastName}");

Stat s1 = new Stat();
s1[StatType.Hp] = 10;
s1[StatType.Force] = 5;
s1[StatType.Defence] = 5;
s1[StatType.Vitesse] = 5;
Stat s2 = new Stat();
s2[StatType.Hp] = 10;
s2[StatType.Force] = 5;
s2[StatType.Defence] = 5;
s2[StatType.Vitesse] = 5;

Stat s3 = s1 + s2;
foreach (StatType s in Enum.GetValues<StatType>())
{
    Console.WriteLine($"{s} : {s3[s]}");
}