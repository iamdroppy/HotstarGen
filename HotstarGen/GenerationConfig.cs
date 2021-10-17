using CommandLine;

namespace HotstarGen
{
    class GenerationConfig
    {
        [Option('i', "input", HelpText = "Liquid pre-gen file", Required = true)]
        public string Input { get; set; }

        [Option('n', "natives", HelpText = "Natives.json file",
            Default = "natives.json")]
        public string Natives { get; set; } = "natives.json";

        [Option('e', "extension", HelpText = "Output file extension", Required = true)]
        public string Extension { get; set; } = ".txt";

        [Option('o', "output", HelpText = "Output directory", Required = true)]
        public string Output { get; set; }

        [Option('v', "verbose", HelpText = "Verbose output")]
        public bool Verbose { get; set; }
        
        [Option('y', "yes", HelpText = "Yes to all - no prompts: just agree with the default value/yes.")]
        public bool NoPrompt { get; set; }
        
        [Option('m', "merged",
            HelpText = "Merge onto a single file")]
        public bool Merged { get; set; }
        
        [Option('c', "auto-close", HelpText = "Auto Close after generation")]
        public bool AutoClose { get; set; }
    }
}