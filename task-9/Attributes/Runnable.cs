using System;

namespace Attributes
{
    // This attribute can be used only on methods
    [AttributeUsage(AttributeTargets.Method)]
    public class RunnableAttribute : Attribute
    {
    }
}