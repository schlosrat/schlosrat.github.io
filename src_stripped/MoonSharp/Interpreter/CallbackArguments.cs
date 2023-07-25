// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.CallbackArguments
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  public class CallbackArguments
  {
    private IList<DynValue> m_Args;
    private int m_Count;
    private bool m_LastIsTuple;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CallbackArguments(IList<DynValue> args, bool isMethodCall) => throw null;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsMethodCall
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public DynValue this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue RawGet(int index, bool translateVoids) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue[] GetArray(int skip = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue AsType(int argNum, string funcName, DataType type, bool allowNil = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T AsUserData<T>(int argNum, string funcName, bool allowNil = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int AsInt(int argNum, string funcName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public long AsLong(int argNum, string funcName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string AsStringUsingMeta(
      ScriptExecutionContext executionContext,
      int argNum,
      string funcName)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CallbackArguments SkipMethodCall() => throw null;
  }
}
