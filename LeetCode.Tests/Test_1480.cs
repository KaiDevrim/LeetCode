namespace LeetCode.Tests;

using Solutions.Solutions;
[TestFixture]
public class Test_1480
{
    private SumOf1DArraySolution _solution;
    [SetUp]
    public void Setup()
    {
        _solution = new SumOf1DArraySolution();
    }

    [Test]
    public void Test1()
    {
        int[] testArray = new int[] {4, 8, 5, 7};
        Assert.That(_solution.RunningSum(testArray), Is.EqualTo(testArray));
    }
}