using System;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Text.RegularExpressions;
using HotstarGen.Models;
using HotstarGen.TemplateHelpers;
using Microsoft.Extensions.Logging;
using Scriban;
using Scriban.Functions;
using Scriban.Parsing;
using Scriban.Runtime;

namespace HotstarGen
{
    class Generation
    {
        private readonly ILogger<Generation> _logger;
        private readonly GenerationConfig _config;
        public Generation(ILogger<Generation> logger, GenerationConfig config)
        {
            _logger = logger;
            _config = config;
        }

        public void Prepare()
        {
            _logger.LogDebug("Checking input/output folders...");

            FileInfo input = new(_config.Input);
            if (input.Exists)
                _logger.LogTrace("Input folder exists.");
            else
                throw new SafeException($"Input file {input.FullName} doesn't exist.");
            DirectoryInfo output = new(_config.Output);
            if (output.Exists)
            {
                _logger.LogTrace("Input folder exists.");
                _logger.LogWarning(output.FullName + " already exists, would you like to delete the content for a new generation?");

                if (!_config.NoPrompt && !YesNo())
                    throw new SafeException($"Output directory {output.FullName} exists but can't be used at the moment.");

                output.Delete(true);
                output.Create();
                output = new(_config.Output);
            }

            PrepareTemplates(input, output);
        }

        private void PrepareTemplates(FileInfo input, DirectoryInfo output)
        {
            _logger.LogDebug("Generating templates...");
            
            if (!input.Exists)
                throw new SafeException(input.FullName + " doesn't exist. It is used to generate the output file. See samples/csharp for more info.");

            using StreamReader templateReader = new(input.OpenRead());
            var nativeFileTemplate = templateReader.ReadToEnd();

            var obj = GetNativesJson().Select(x => new GeneratedData()
            {
                Category = x.Key,
                Natives = x.Value.Select(x => x.Value)
                    .OrderBy(s=>string.IsNullOrWhiteSpace(s.Comment))
                    .ThenBy(s=>s.Name.StartsWith("_0x"))
                    .ToArray()
            });
            var outputMerge = "";
            foreach (var r in obj)
            {
                string fileName = r.Category;
                fileName = char.ToUpper(fileName[0]) + string.Concat(fileName.Skip(1));
                var outputFile = new DirectoryInfo(Path.Join(output.FullName, fileName + _config.Extension));
                var template = Template.ParseLiquid(nativeFileTemplate);
                var content = Regex.Replace(Evaluate(template, r), @"\n\s+\n", "\n");
                if (!_config.Merged)
                    File.WriteAllText(outputFile.FullName, content);
                else
                {
                    outputMerge += content;
                }
                _logger.LogTrace("Saved " + fileName);
            }

            if (_config.Merged)
            {
                File.WriteAllText(Path.Join(output.FullName, "native" + _config.Extension), outputMerge);
            }
            
            _logger.LogInformation("Completed!");
        }

        private string? Evaluate(Template template, object? model)
        {
            var scriptObject = new ScriptObject();
            if (model != null)
            {
                scriptObject.Import(model);
            }

            scriptObject.Import(new StringFunctions());

            var context = new TemplateContext {LoopLimit = 100000};
            
            context.PushGlobal(scriptObject);
            var result = template.Render(context);
            context.PopGlobal();
            return result as string;
        }
        private CategoriesModel GetNativesJson()
        {
            var categories = JsonSerializer.Deserialize<CategoriesModel>(File.ReadAllText(_config.Natives), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true});
            foreach (var v in categories)
            {
                v.Value.Hash = v.Key;
                foreach (var c in v.Value)
                {
                    c.Value.Hash = c.Key;
                }
            }
            return categories;
        }
        
        private bool YesNo()
        {
            while (true)
            {
                try
                {
                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Y) return true;
                    if (key.Key == ConsoleKey.N) return false;
                }
                finally
                {
                    Console.CursorLeft--;
                }
            }
        }
    }
}