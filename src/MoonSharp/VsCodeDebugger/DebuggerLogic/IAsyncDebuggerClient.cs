// Decompiled with JetBrains decompiler
// Type: MoonSharp.VsCodeDebugger.DebuggerLogic.IAsyncDebuggerClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Debugging;

namespace MoonSharp.VsCodeDebugger.DebuggerLogic
{
  internal interface IAsyncDebuggerClient
  {
    void SendStopEvent();

    void OnWatchesUpdated(WatchType watchType);

    void OnSourceCodeChanged(int sourceID);

    void OnExecutionEnded();

    void OnException(ScriptRuntimeException ex);

    void Unbind();
  }
}
