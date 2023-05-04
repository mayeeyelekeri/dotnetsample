namespace test_library;

using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;
using static library.Class1;

public class UnitTest1
{
    [Fact]
    public void passTestCase()
    {
        Assert.Equal(30, new Thing().Get(10, 20));        
    }

    [Fact]
    public void failTestCase()
    {
        Assert.NotEqual(50, new Thing().Get(10, 20));
    }
}