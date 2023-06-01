// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Statements.AssignmentStatement
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
  internal class AssignmentStatement : Statement
  {
    private List<IVariable> m_LValues;
    private List<Expression> m_RValues;
    private SourceRef m_Ref;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssignmentStatement(ScriptLoadingContext lcontext, Token startToken) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssignmentStatement(
      ScriptLoadingContext lcontext,
      Expression firstExpression,
      Token first)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IVariable CheckVar(ScriptLoadingContext lcontext, Expression firstExpression) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Compile(ByteCode bc) => throw null;
  }
}
