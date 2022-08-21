using NUnit.Framework;
using CodeJam;

namespace FirstConsoleApp.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        string str = "";
        Code.NotNullNorEmpty(str, nameof (str));
    }
}