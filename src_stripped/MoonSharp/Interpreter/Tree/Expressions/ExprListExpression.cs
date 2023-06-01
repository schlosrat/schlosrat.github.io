// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Expressions.ExprListExpression
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Tree.Expressions
{
  internal class ExprListExpression : Expression
  {
    private List<Expression> expressions;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ExprListExpression(List<Expression> exps, ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Expression[] GetExpressions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Compile(ByteCode bc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DynValue Eval(ScriptExecutionContext context) => throw null;
  }
}
