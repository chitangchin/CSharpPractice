
namespace C_SandBoxTest
{
    using Sandbox.SplitMethod;
    public class SplitMethodTests
    {
        public void Tests()
        {
            string test = "Hello Test 1 2";
            Assert.That(SolutionClass.SplitMethod(test), Is.EqualTo(test.Split(" ")));
        }
    }
}
