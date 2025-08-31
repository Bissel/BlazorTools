namespace Bissel.BlazorTools;

public static class Tools
{
    public static string GetResourcePath(Type type) => type.Assembly.GetName().Name!;
}