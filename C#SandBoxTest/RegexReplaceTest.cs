namespace C_SandBoxTest
{
    using Sandbox.Regex;
    using NUnit.Framework;
    [TestFixture]
    public class RegexReplaceTests
    {
        [Test]
        public void Tests()
        {
            string test = "hello!^";
            Assert.That(SolutionClass.RegexReplace(test), Is.EqualTo("hello"));
        }
    }
}
