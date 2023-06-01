// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.REPL.ReplHistoryInterpreter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
