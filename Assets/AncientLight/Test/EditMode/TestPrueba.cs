using NUnit.Framework;

public class TestPrueba
{
    // A Test behaves as an ordinary method
    [Test]
    public void TestPruebaSimplePasses()
    {
        Assert.Pass();
        Assert.That(1, Is.EqualTo(1));
    }
}
