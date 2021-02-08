namespace TesteRecords.Model
{
    public record Bonacera 
    {
        public string Name {get; init;}

        public string SayBonacera() => $"Bonacera {Name}";
    }
}