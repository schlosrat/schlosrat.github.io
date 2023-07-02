// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Compatibility.Frameworks.FrameworkReflectionBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Compatibility.Frameworks
{
  internal abstract class FrameworkReflectionBase : FrameworkBase
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Type GetTypeInfoFromType(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Assembly GetAssembly(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type GetBaseType(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool IsValueType(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool IsInterface(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool IsNestedPublic(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool IsAbstract(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool IsEnum(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool IsGenericTypeDefinition(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool IsGenericType(Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Attribute[] GetCustomAttributes(Type t, bool inherit) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Attribute[] GetCustomAttributes(Type t, Type at, bool inherit) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected FrameworkReflectionBase() => throw null;
  }
}
