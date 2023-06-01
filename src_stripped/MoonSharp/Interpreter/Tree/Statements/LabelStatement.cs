// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Statements.LabelStatement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Tree.Statements
{
  internal class LabelStatement : Statement
  {
    private List<GotoStatement> m_Gotos;
    private RuntimeScopeBlock m_StackFrame;

    public string Label
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int Address
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public SourceRef SourceRef
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Token NameToken
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    internal int DefinedVarsCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    internal string LastDefinedVarName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LabelStatement(ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void SetDefinedVars(int definedVarsCount, string lastDefinedVarsName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void RegisterGoto(GotoStatement gotostat) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Compile(ByteCode bc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void SetScope(RuntimeScopeBlock runtimeScopeBlock) => throw null;
  }
}
