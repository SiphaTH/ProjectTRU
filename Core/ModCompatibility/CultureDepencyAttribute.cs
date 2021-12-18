using System;

namespace CalamityRuTranslate.Core.ModCompatibility
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CultureDependencyAttribute : Attribute
    {
        public string Culture { get; }

        public CultureDependencyAttribute(string culture)
        {
           Culture = culture;
        }
    }
}