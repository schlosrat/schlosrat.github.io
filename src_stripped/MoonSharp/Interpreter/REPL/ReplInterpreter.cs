// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.REPL.ReplInterpreter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.REPL
{
  public class ReplInterpreter
  {
    private Script m_Script;
    private string m_CurrentCommand;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ReplInterpreter(Script script) => throw null;

    public bool HandleDynamicExprs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool HandleClassicExprsSyntax
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public virtual bool HasPendingCommand
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public virtual string CurrentPendingCommand
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public virtual string ClassicPrompt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DynValue Evaluate(string input) => throw null;
  }
}
