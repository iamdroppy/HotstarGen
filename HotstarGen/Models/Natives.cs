using System.Collections.Generic;

namespace HotstarGen.Models
{
    public class Natives : Dictionary<string, NativeFunction>
    {
        public string Hash { get; set; }
    }
}