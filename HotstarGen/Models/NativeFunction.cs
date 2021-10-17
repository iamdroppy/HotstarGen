using System;
using System.Text.Json.Serialization;

namespace HotstarGen.Models
{
    public class NativeFunction
    {
        public string Hash { get; set; } = "";
        public string Name { get; set; } = "";
        public string Comment { get; set; } = "";

        public NativeParam[] Params { get; set; } = Array.Empty<NativeParam>();

        [JsonPropertyName("return_type")] public string ReturnType { get; set; } = "";

        public string Build { get; set; } = "";
	    
        public override string ToString() => Name;
    }
}