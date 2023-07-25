// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Debugging.IDebugger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;

namespace MoonSharp.Interpreter.Debugging
{
  public interface IDebugger
  {
    DebuggerCaps GetDebuggerCaps();

    void SetDebugService(DebugService debugService);

    void SetSourceCode(SourceCode sourceCode);

    void SetByteCode(string[] byteCode);

    bool IsPauseRequested();

    bool SignalRuntimeException(ScriptRuntimeException ex);

    DebuggerAction GetAction(int ip, SourceRef sourceref);

    void SignalExecutionEnded();

    void Update(WatchType watchType, IEnumerable<WatchItem> items);

    List<DynamicExpression> GetWatchItems();

    void RefreshBreakpoints(IEnumerable<SourceRef> refs);
  }
}
