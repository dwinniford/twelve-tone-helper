using Xunit;

namespace TwelveToneHelper.Tests;

public class ToneRowTests
{
    [Fact]
    public void GeneratesRowOfTwelve()
    {
        ToneRow row = new ToneRow();
        Assert.Equal(12, row.GetLength());
    }
}