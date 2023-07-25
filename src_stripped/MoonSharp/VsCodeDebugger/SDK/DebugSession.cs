// Decompiled with JetBrains decompiler
// Type: MoonSharp.VsCodeDebugger.SDK.DebugSession
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace MoonSharp.VsCodeDebugger.SDK
{
  public abstract class DebugSession : ProtocolServer
  {
    private bool _debuggerLinesStartAt1;
    private bool _debuggerPathsAreURI;
    private bool _clientLinesStartAt1;
    private bool _clientPathsAreURI;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DebugSession(bool debuggerLinesStartAt1, bool debuggerPathsAreURI = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SendResponse(Response response, ResponseBody body = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SendErrorResponse(
      Response response,
      int id,
      string format,
      object arguments = null,
      bool user = true,
      bool telemetry = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DispatchRequest(string command, Table args, Response response) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void Initialize(Response response, Table args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void Launch(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void Attach(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void Disconnect(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetFunctionBreakpoints(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetExceptionBreakpoints(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void SetBreakpoints(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void Continue(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void Next(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void StepIn(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void StepOut(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void Pause(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void StackTrace(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void Scopes(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void Variables(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Source(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void Threads(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void Evaluate(Response response, Table arguments) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected int ConvertDebuggerLineToClient(int line) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected int ConvertClientLineToDebugger(int line) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected string ConvertDebuggerPathToClient(string path) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected string ConvertClientPathToDebugger(string clientPath) => throw null;
  }
}
