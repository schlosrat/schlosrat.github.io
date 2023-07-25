// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Coroutine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution.VM;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  public class Coroutine : RefIdObject, IScriptPrivateResource
  {
    private CallbackFunction m_ClrCallback;
    private Processor m_Processor;

    public Coroutine.CoroutineType Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Coroutine(CallbackFunction function) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Coroutine(Processor proc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void MarkClrCallbackAsDead() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<DynValue> AsTypedEnumerable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<object> AsEnumerable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<T> AsEnumerable<T>() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator AsUnityCoroutine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Resume(params DynValue[] args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Resume(ScriptExecutionContext context, params DynValue[] args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Resume() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Resume(ScriptExecutionContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Resume(params object[] args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Resume(ScriptExecutionContext context, params object[] args) => throw null;

    public CoroutineState State
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WatchItem[] GetStackTrace(int skip, SourceRef entrySourceRef = null) => throw null;

    public Script OwnerScript
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public long AutoYieldCounter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public enum CoroutineType
    {
      Coroutine,
      ClrCallback,
      ClrCallbackDead,
    }
  }
}
