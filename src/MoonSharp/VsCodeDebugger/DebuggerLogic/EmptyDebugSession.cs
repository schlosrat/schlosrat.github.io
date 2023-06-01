// Decompiled with JetBrains decompiler
// Type: MoonSharp.VsCodeDebugger.DebuggerLogic.EmptyDebugSession
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using MoonSharp.VsCodeDebugger.SDK;
using System.Runtime.CompilerServices;

namespace MoonSharp.VsCodeDebugger.DebuggerLogic
{
  internal class EmptyDebugSession : DebugSession
  {
    private MoonSharpVsCodeDebugServer m_Server;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal EmptyDebugSession(MoonSharpVsCodeDebugServer server) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize(Response response, Table args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SendList() => throw null;

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
    public override void Pause(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Scopes(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetBreakpoints(Response response, Table args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void StackTrace(Response response, Table args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void StepIn(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void StepOut(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Threads(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Variables(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SendText(string msg, params object[] args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Unbind() => throw null;
  }
}
