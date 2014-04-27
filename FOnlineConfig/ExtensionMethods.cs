//
// Enables extension methods for .NET 2.0;
//
namespace System.Runtime.CompilerServices
{
    [AttributeUsage( AttributeTargets.Assembly | AttributeTargets.Class |
        AttributeTargets.Method )]
    public sealed class ExtensionAttribute : Attribute { }
}
