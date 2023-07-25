// Decompiled with JetBrains decompiler
// Type: MoonSharp.VsCodeDebugger.DebuggerLogic.IAsyncDebuggerClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
