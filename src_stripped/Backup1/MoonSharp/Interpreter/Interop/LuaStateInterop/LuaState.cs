// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.LuaStateInterop.LuaState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop.LuaStateInterop
{
  public class LuaState
  {
    private List<DynValue> m_Stack;

    public ScriptExecutionContext ExecutionContext
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public string FunctionName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal LuaState(
      ScriptExecutionContext executionContext,
      CallbackArguments args,
      string functionName)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Top(int pos = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue At(int pos) => throw null;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Push(DynValue v) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Pop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue[] GetTopArray(int num) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue GetReturnValue(int retvals) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Discard(int nargs) => throw null;
  }
}
