// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ScriptEnvironmentInterop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  public class ScriptEnvironmentInterop
  {
    private ScriptEnvironment scriptEnvironment;
    public TypeInterop typeInterop;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptEnvironmentInterop(ScriptEnvironment scriptEnvironment, TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(Type dotNetType, object objectValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue<T>(T objectValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object ToValue(Type dotNetType, DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T ToValue<T>(DynValue scriptValue) => throw null;
  }
}
