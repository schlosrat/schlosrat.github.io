// Decompiled with JetBrains decompiler
// Type: MoonSharp.VsCodeDebugger.DebuggerLogic.AsyncDebugger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Debugging;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace MoonSharp.VsCodeDebugger.DebuggerLogic
{
  internal class AsyncDebugger : IDebugger
  {
    private static object s_AsyncDebuggerIdLock;
    private static int s_AsyncDebuggerIdCounter;
    private object m_Lock;
    private IAsyncDebuggerClient m_Client__;
    private DebuggerAction m_PendingAction;
    private List<WatchItem>[] m_WatchItems;
    private Dictionary<int, SourceCode> m_SourcesMap;
    private Dictionary<int, string> m_SourcesOverride;
    private Func<SourceCode, string> m_SourceFinder;

    public DebugService DebugService
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Regex ErrorRegex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Script Script
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool PauseRequested
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int Id
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AsyncDebugger(Script script, Func<SourceCode, string> sourceFinder, string name) => throw null;

    public IAsyncDebuggerClient Client
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    DebuggerAction IDebugger.GetAction(int ip, SourceRef sourceref) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void QueueAction(DebuggerAction action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Sleep(int v) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynamicExpression CreateDynExpr(string code) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    List<DynamicExpression> IDebugger.GetWatchItems() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    bool IDebugger.IsPauseRequested() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IDebugger.RefreshBreakpoints(IEnumerable<SourceRef> refs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IDebugger.SetByteCode(string[] byteCode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IDebugger.SetSourceCode(SourceCode sourceCode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetFooterForTempFile() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetSourceFile(int sourceId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsSourceOverride(int sourceId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IDebugger.SignalExecutionEnded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    bool IDebugger.SignalRuntimeException(ScriptRuntimeException ex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IDebugger.Update(WatchType watchType, IEnumerable<WatchItem> items) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<WatchItem> GetWatches(WatchType watchType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SourceCode GetSource(int id) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SourceCode FindSourceByName(string path) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IDebugger.SetDebugService(DebugService debugService) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Evaluate(string expression) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    DebuggerCaps IDebugger.GetDebuggerCaps() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static AsyncDebugger() => throw null;
  }
}
