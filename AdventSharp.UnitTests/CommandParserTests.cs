using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AdventSharp.UnitTests
{
    [TestFixture]
    public class CommandParserTests
    {
        private TestCommandParser _parser = new TestCommandParser();
        
        [Test]
        public void GetCommand_Test()
        {
            TestSuccessfulParse<GetCommand>("get", "knife");
        }

        private void TestSuccessfulParse<T>(params string[] commandWords)
        {
            Command cmd = _parser.ParseCommand(commandWords);
            Assert.IsTrue(cmd.ParsedSuccessfully);
            Assert.IsTrue(cmd is T);
        }
    }

    public class TestCommandParser : CommandParser
    {
        protected override Command ParseCustomComamnd(string[] commandWords)
        {
            return base.ParseCustomComamnd(commandWords);
        }
    }
}
