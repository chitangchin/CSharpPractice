
namespace C_SandBoxTest
{
    using Sandbox.SplitMethod;
    using NUnit.Framework;
    [TestFixture]
    public class SplitMethodTests
    {
        [Test]
        public void Tests()
        {
            string test = "Hello Test 1 2";
            Assert.That(SolutionClass.SplitMethod(test), Is.EqualTo(test.Split(" ")));
        }
    }
}