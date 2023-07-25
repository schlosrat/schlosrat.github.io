// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.REPL.ReplHistoryInterpreter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.REPL
{
  public class ReplHistoryInterpreter : ReplInterpreter
  {
    private string[] m_History;
    private int m_Last;
    private int m_Navi;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ReplHistoryInterpreter(Script script, int historySize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DynValue Evaluate(string input) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string HistoryPrev() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string HistoryNext() => throw null;
  }
}
