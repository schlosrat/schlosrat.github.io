// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ScriptEnvironmentInterop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
