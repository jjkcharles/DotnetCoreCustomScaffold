using Microsoft.VisualStudio.Web.CodeGeneration;
using Microsoft.VisualStudio.Web.CodeGeneration.CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApp.CodeGenerator
{
    [Alias("test")]
    public class TestCodeGenerator : ICodeGenerator
    {
        public async Task GenerateCode(TestCodeGeneratorModel model)
        {
            await Task.CompletedTask;

            throw new NotImplementedException();
        }
    }

    public class TestCodeGeneratorModel
    {
        [Option(Name = "controllerName", ShortName = "name", Description = "Name of the controller")]
        public string ControllerName { get; set; }

        [Option(Name = "readWriteActions", ShortName = "actions", Description = "Specify this switch to generate Controller with read/write actions when a Model class is not used")]
        public bool GenerateReadWriteActions { get; set; }
    }
}
