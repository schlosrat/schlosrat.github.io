// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ScriptEnvironment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Loaders;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  public class ScriptEnvironment : IScriptEnvironment, ITypeInterop
  {
    private IRunScriptInterop privilededInterop;
    private IScriptEnvironmentOwner owner;
    private KSP.ScriptInterop.impl.moonsharp.TypeWriter typeWriter;
    public Script script;
    public Table globals;
    public ScriptValue NilValue;
    private static bool warned;

    public IRunScriptInterop RunInterop
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ITypeInterop TypeInterop
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ScriptEnvironmentInterop typeInteropAssistant
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ITypeWriter TypeWriter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IScriptLoader ScriptLoader
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Action<string> DebugPrint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public string name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool DataLinkEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptEnvironment(
      IScriptEnvironmentOwner owner,
      Script previous,
      Table table,
      string name,
      bool allowExternalInterop,
      KSP.ScriptInterop.impl.moonsharp.TypeInterop typeInterp,
      KSP.ScriptInterop.impl.moonsharp.TypeWriter typeWriter)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptEnvironment(
      IScriptEnvironmentOwner owner,
      string name,
      bool allowExternalInterop,
      KSP.ScriptInterop.impl.moonsharp.TypeInterop typeInterp,
      KSP.ScriptInterop.impl.moonsharp.TypeWriter typeWriter)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Dictionary<string, string> GetTypes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ICompiledScript Compile(string scriptCode, string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public byte[] CompileToBytes(string scriptCode, string name = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object ToValue(Type dotNetType, IScriptValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IScriptValue FromValue(Type dotNetType, object objectValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T ToValue<T>(IScriptValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IScriptValue FromValue<T>(T objectValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IScriptEnvironment Fork(string name, bool allowExternalInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IScriptValue RunCompiledAssetScript(ICompiledScript script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IScriptValue RunScriptAsset(ICompiledScript scriptAsset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IScriptObject RegisterScriptObject(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IScriptObject RegisterScriptObject(string name, IScriptObject parent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UsedOnlyForAOTCodeGeneration() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ScriptEnvironment() => throw null;
  }
}
