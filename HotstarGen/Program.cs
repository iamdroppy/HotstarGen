using System;
using CommandLine;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HotstarGen
{
    static class Program
    {
        public static int Main(string[] args)
        {
            args = "-i input/csharp.liquid -e .cs -o output2 -y -v".Split(' ');
            Parser.Default.ParseArguments<GenerationConfig>(args)
                .WithParsed<GenerationConfig>(o =>
                {
                    IServiceCollection collection = new ServiceCollection();
                    var provider = collection.AddLogging(l =>
                            l.AddConsole().SetMinimumLevel(o.Verbose ? LogLevel.Debug : LogLevel.Information))
                        .AddSingleton<GenerationConfig>(o)
                        .AddSingleton<Generation>()
                        .BuildServiceProvider();

                    try
                    {
                        provider.GetRequiredService<Generation>().Prepare();
                    }
                    catch (SafeException ex)
                    {
                        provider.GetRequiredService<ILogger<Generation>>().LogCritical(ex.Message, ex);
                    }

                    if (!o.AutoClose)
                    {
                        Console.WriteLine("Done - press any key to close.");
                        Console.ReadKey();
                    }
                });

            return 0;
        }
    }
}