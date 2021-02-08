using TesteRecords.Model;
using static System.Console;

var bonacera1 = new Bonacera { Name = "Natasha" };
WriteLine(bonacera1.SayBonacera());
var bonacera2 = bonacera1 with { Name = "Katucha" };
WriteLine(bonacera2.SayBonacera());

var bonacera3 = new Bonacera {Name = "Natasha"};
WriteLine(bonacera3 == bonacera1);
WriteLine(bonacera3 == bonacera2);

WriteLine(bonacera1);
WriteLine(bonacera2);
WriteLine(bonacera3);

var clone  = bonacera3 with {};
WriteLine(clone);