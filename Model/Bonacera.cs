namespace TesteRecords.Model
{
    public record Bonacera(string Name)
    {
        public string SayBonacera() => $"Bonacera {Name}";
    }
}