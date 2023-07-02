// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Compatibility.Frameworks.FrameworkBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Compatibility.Frameworks
{
  public abstract class FrameworkBase
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool StringContainsChar(string str, char chr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool IsValueType(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Assembly GetAssembly(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Type GetBaseType(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool IsGenericType(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool IsGenericTypeDefinition(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool IsEnum(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool IsNestedPublic(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool IsAbstract(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool IsInterface(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Attribute[] GetCustomAttributes(Type t, bool inherit) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Attribute[] GetCustomAttributes(Type t, Type at, bool inherit) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Type[] GetInterfaces(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool IsInstanceOfType(Type t, object o) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract MethodInfo GetAddMethod(EventInfo ei) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract MethodInfo GetRemoveMethod(EventInfo ei) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract MethodInfo GetGetMethod(PropertyInfo pi) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract MethodInfo GetSetMethod(PropertyInfo pi) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Type GetInterface(Type type, string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract PropertyInfo[] GetProperties(Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract PropertyInfo GetProperty(Type type, string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Type[] GetNestedTypes(Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract EventInfo[] GetEvents(Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract ConstructorInfo[] GetConstructors(Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Type[] GetAssemblyTypes(Assembly asm) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract MethodInfo[] GetMethods(Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract FieldInfo[] GetFields(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract MethodInfo GetMethod(Type type, string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Type[] GetGenericArguments(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool IsAssignableFrom(Type current, Type toCompare) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool IsDbNull(object o) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract MethodInfo GetMethod(Type resourcesType, string v, Type[] type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected FrameworkBase() => throw null;
  }
}
