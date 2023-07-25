// Decompiled with JetBrains decompiler
// Type: MoonSharp.VsCodeDebugger.MoonSharpVsCodeDebugServer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Debugging;
using MoonSharp.VsCodeDebugger.DebuggerLogic;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;

namespace MoonSharp.VsCodeDebugger
{
  public class MoonSharpVsCodeDebugServer : IDisposable
  {
    private object m_Lock;
    private List<AsyncDebugger> m_DebuggerList;
    private AsyncDebugger m_Current;
    private ManualResetEvent m_StopEvent;
    private bool m_Started;
    private int m_Port;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MoonSharpVsCodeDebugServer(int port = 41912) => throw null;

    [Obsolete("Use the constructor taking only a port, and the 'Attach' method instead.")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MoonSharpVsCodeDebugServer(
      Script script,
      int port,
      Func<SourceCode, string> sourceFinder = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AttachToScript(Script script, string name, Func<SourceCode, string> sourceFinder = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<KeyValuePair<int, string>> GetAttachedDebuggersByIdAndName() => throw null;

    public int? CurrentId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Script Current
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Detach(Script script) => throw null;

    public Action<string> Logger
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [Obsolete("Use the Attach method instead.")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IDebugger GetDebugger() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MoonSharpVsCodeDebugServer Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ListenThread(TcpListener serverSocket) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RunSession(string sessionId, NetworkStream stream) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Log(string format, params object[] args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SpawnThread(string name, Action threadProc) => throw null;
  }
}
