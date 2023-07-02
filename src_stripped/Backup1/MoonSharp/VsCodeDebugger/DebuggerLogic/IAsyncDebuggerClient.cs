// Decompiled with JetBrains decompiler
// Type: MoonSharp.VsCodeDebugger.DebuggerLogic.IAsyncDebuggerClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
