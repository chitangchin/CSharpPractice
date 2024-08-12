using Sandbox.SplitMethod;

namespace C_SandBoxTest
{
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
