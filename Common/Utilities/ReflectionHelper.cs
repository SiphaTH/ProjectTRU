using System;
using System.Collections.Generic;
using System.Reflection;

namespace CalamityRuTranslate.Common.Utilities;

internal static class ReflectionHelper
{
    private enum ReflectionType
    {
        Field,
        Property,
        Method,
        Constructor,
        Type
    }
        
    private static Dictionary<ReflectionType, Dictionary<string, object>> ReflectionCache => new()
    {
        {ReflectionType.Field, new Dictionary<string, object>()},
        {ReflectionType.Property, new Dictionary<string, object>()},
        {ReflectionType.Type, new Dictionary<string, object>()},
        {ReflectionType.Constructor, new Dictionary<string, object>()},
        {ReflectionType.Method, new Dictionary<string, object>()}
    };

    private static BindingFlags UniversalFlags => BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

    internal static MethodInfo GetCachedMethod(this Type type, string methodName) => RetrieveFromCache(
        ReflectionType.Method, GetMethodNameForCache(type, methodName),
        () => type.GetMethod(methodName, UniversalFlags));

    private static string GetMethodNameForCache(Type type, string method)
    {
        string assemblyName = type.Assembly.GetName().Name;
        string typeName = type.Name;
        return $"{assemblyName}.{typeName}::{method}";
    }

    private static TReturn RetrieveFromCache<TReturn>(ReflectionType refType, string key, Func<TReturn> fallback)
    {
        if (ReflectionCache[refType].ContainsKey(key))
            return (TReturn)ReflectionCache[refType][key];

        TReturn value = fallback();
        ReflectionCache[refType].Add(key, value);
        return value;
    }
}