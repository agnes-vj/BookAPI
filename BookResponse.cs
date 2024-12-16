using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace APIExamples
{
    internal class BookResponse
    {
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;
        [JsonPropertyName("seed")]
        public string Seed { get; set; } = string.Empty;
        [JsonPropertyName("Total")]
        public int Total { get; set; } = 0;

        [JsonPropertyName("data")]
        public List<Result> Results { get; set; } = new();


    }
}
