// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Closure
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Execution;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  public class Closure : RefIdObject, IScriptPrivateResource
  {
    private static ClosureContext emptyClosure;

    public int EntryPointByteCodeLocation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Script OwnerScript
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    internal ClosureContext ClosureContext
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Closure(
      Script script,
      int idx,
      SymbolRef[] symbols,
      IEnumerable<DynValue> resolvedLocals)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Call() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Call(params object[] args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Call(params DynValue[] args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptFunctionDelegate GetDelegate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptFunctionDelegate<T> GetDelegate<T>() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetUpvaluesCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetUpvalueName(int idx) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue GetUpvalue(int idx) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Closure.UpvaluesType GetUpvaluesType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Closure() => throw null;

    public enum UpvaluesType
    {
      None,
      Environment,
      Closure,
    }
  }
}
