// Decompiled with JetBrains decompiler
// Type: MoonSharp.VsCodeDebugger.DebuggerLogic.MoonSharpDebugSession
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.VsCodeDebugger.SDK;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.VsCodeDebugger.DebuggerLogic
{
  internal class MoonSharpDebugSession : DebugSession, IAsyncDebuggerClient
  {
    private AsyncDebugger m_Debug;
    private MoonSharpVsCodeDebugServer m_Server;
    private List<DynValue> m_Variables;
    private bool m_NotifyExecutionEnd;
    private const int SCOPE_LOCALS = 65536;
    private const int SCOPE_SELF = 65537;
    private readonly SourceRef DefaultSourceRef;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal MoonSharpDebugSession(MoonSharpVsCodeDebugServer server, AsyncDebugger debugger) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize(Response response, Table args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Attach(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Continue(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Disconnect(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string getString(Table args, string property, string dflt = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Evaluate(Response response, Table args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecuteRepl(string cmd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Launch(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Next(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private StoppedEvent CreateStoppedEvent(string reason, string text = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Pause(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Scopes(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetBreakpoints(Response response, Table args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void StackTrace(Response response, Table args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int getInt(Table args, string propName, int defaultValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void StepIn(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void StepOut(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Threads(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Variables(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IAsyncDebuggerClient.SendStopEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IAsyncDebuggerClient.OnWatchesUpdated(WatchType watchType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IAsyncDebuggerClient.OnSourceCodeChanged(int sourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnExecutionEnded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SendText(string msg, params object[] args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnException(ScriptRuntimeException ex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Unbind() => throw null;
  }
}
