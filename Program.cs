using System.Collections.Generic;
using System.Collections.ObjectModel;
using TesteRecords.Model;
using static System.Console;

var bonacera1 = new Bonacera("Natasha");
WriteLine(bonacera1.SayBonacera());
var bonacera2 = bonacera1 with { Name = "Katucha" };
WriteLine(bonacera2.SayBonacera());

var bonacera3 = new Bonacera("Natasha");
WriteLine(bonacera3 == bonacera1);
WriteLine(bonacera3 == bonacera2);

WriteLine(bonacera1);
WriteLine(bonacera2);
WriteLine(bonacera3);

var clone = bonacera3 with { };
WriteLine(clone);

var firstDoctor = new Doctor("1ª Doctor", new ReadOnlyCollection<string>(new List<string>() { "Susan", "Barbara", "Ian" }));
firstDoctor.Log(WriteLine);

firstDoctor = firstDoctor with { Companions = new ReadOnlyCollection<string>(new List<string>() { "Vicki", "Steven Taylor", "Katarina" }) };
firstDoctor.Log(WriteLine);