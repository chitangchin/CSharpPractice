namespace C_SandBoxTest
{
    using Sandbox.Regex;
    public class RegexReplaceTests
    {
        public void Tests()
        {
            string test = "1231312@!#!@#!@asdasfa@!#!@%!@%!#^";
            Assert.That(SolutionClass.RegexReplace(test), Is.EqualTo("1231312asdasfa"));
        }
    }
}
