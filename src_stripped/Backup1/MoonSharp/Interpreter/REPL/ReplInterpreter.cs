// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.REPL.ReplInterpreter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
