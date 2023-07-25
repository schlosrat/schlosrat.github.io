// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Expression
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Execution;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Tree
{
  internal abstract class Expression : NodeBase
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Expression(ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string GetFriendlyDebugName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract DynValue Eval(ScriptExecutionContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SymbolRef FindDynamic(ScriptExecutionContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static List<Expression> ExprListAfterFirstExpr(
      ScriptLoadingContext lcontext,
      Expression expr1)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static List<Expression> ExprList(ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Expression Expr(ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Expression SubExpr(ScriptLoadingContext lcontext, bool isPrimary) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Expression SimpleExp(ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Expression PrimaryExp(ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Expression PrefixExp(ScriptLoadingContext lcontext) => throw null;
  }
}
