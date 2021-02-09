using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesteRecords.Model
{
    public record Doctor(string Regeneration, IReadOnlyCollection<string> Companions)
    {
        public void Log(Action<string> log)
        {
            StringBuilder sb = new($"Regeneration: {Regeneration}");
            sb.AppendLine();
            sb.AppendLine($"Companions: {Companions.Aggregate((result, next) => $"{result} - {next}")}");
            log(sb.ToString());
        }
    }
}