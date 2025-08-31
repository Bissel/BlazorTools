namespace Bissel.BlazorTools.Tests;

public class ToolsTests
{
    [Test]
    public void ResourcePath()
    {
        const string expected = "Bissel.BlazorTools.Tests";

        var actual = Tools.GetResourcePath(typeof(ToolsTests));
        
        Assert.That(actual, Is.EqualTo(expected));
    }
}