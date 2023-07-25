// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.ScriptExecutionContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution.VM;
using MoonSharp.Interpreter.Interop.LuaStateInterop;
using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  public class ScriptExecutionContext : IScriptPrivateResource
  {
    private Processor m_Processor;
    private CallbackFunction m_Callback;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ScriptExecutionContext(
      Processor p,
      CallbackFunction callBackFunction,
      SourceRef sourceRef,
      bool isDynamic = false)
    {
      throw null;
    }

    public bool IsDynamicExecution
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public SourceRef CallingLocation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public object AdditionalData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Table GetMetatable(DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue GetMetamethod(DynValue value, string metamethod) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue GetMetamethodTailCall(
      DynValue value,
      string metamethod,
      params DynValue[] args)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue GetBinaryMetamethod(DynValue op1, DynValue op2, string eventName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Script GetScript() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Coroutine GetCallingCoroutine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue EmulateClassicCall(
      CallbackArguments args,
      string functionName,
      Func<LuaState, int> callback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Call(DynValue func, params DynValue[] args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue EvaluateSymbol(SymbolRef symref) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue EvaluateSymbolByName(string symbol) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SymbolRef FindSymbolByName(string symbol) => throw null;

    public Table CurrentGlobalEnv
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PerformMessageDecorationBeforeUnwind(
      DynValue messageHandler,
      ScriptRuntimeException exception)
    {
      throw null;
    }

    public Script OwnerScript
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }
  }
}
