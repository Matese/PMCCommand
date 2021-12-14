// Copyright (c) 2017 Benjamin Trent. All rights reserved. See LICENSE file in project root

namespace PMCCommand
{
    using System.Collections.Generic;
    using CommandLine;
    using CommandLine.Text;

    /// <summary>
    /// Command line options.
    /// </summary>
    public class CmdLineOptions
    {
        /// <summary>
        /// Gets examples.
        /// </summary>
        [Usage(ApplicationAlias = "PMCCommand")]
        public static IEnumerable<Example> Examples
        {
            get
            {
                return new List<Example>()
                {
                    new Example("Update-Package", new CmdLineOptions
                    {
                        NuGetCommand = "\"Update-Package Newtonsoft.Json\"",
                        ProjectPath = "\"C:\\Foo\\Bar\\foobar.csproj\"",
                    }),
                };
            }
        }

        /// <summary>
        /// Gets or sets the NuGet package management console command to execute.
        /// </summary>
        [Option('n', "nugetcommand", Required = true, HelpText = "The NuGet package management console command to execute.")]
        public string NuGetCommand { get; set; }

        /// <summary>
        /// Gets or sets the full path of the .csproj or .sln file in which to run the command.
        /// </summary>
        [Option('p', "project", Required = true, HelpText = "The full path of the .csproj or .sln file in which to run the command.")]
        public string ProjectPath { get; set; }

        /// <summary>
        /// Gets or sets the VisualStudio version for DTE interaction.
        /// </summary>
        [Option('v', "vsversion", Required = false, HelpText = "The VisualStudio version for DTE interaction.", Default = "17.0")]
        public string VisualStudioVersion { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether print debuging output to the console.
        /// </summary>
        [Option('d', "debug", Required = false, HelpText = "Print debuging output to the console.", Default = false)]
        public bool Debug { get; set; }
    }
}
