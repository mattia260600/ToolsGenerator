using System;
using ToolsGenerator;
using Xunit;

namespace ToolGenerator.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ToolsRepository repository = new ToolsRepository(@"F:\MyProjects\ToolsGenerator");
        }
    }
}
