using TesteRecords.Model;
using static System.Console;

var bonacera1 = new Bonacera { Name = "Natasha" };
WriteLine(bonacera1.SayBonacera());
var bonacera2 = bonacera1 with { Name = "Katucha" };
WriteLine(bonacera2.SayBonacera());
