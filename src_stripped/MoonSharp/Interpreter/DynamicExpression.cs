// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.DynamicExpression
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter.Tree.Expressions;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  public class DynamicExpression : IScriptPrivateResource
  {
    private DynamicExprExpression m_Exp;
    private DynValue m_Constant;
    public readonly string ExpressionCode;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DynamicExpression(Script S, string strExpr, DynamicExprExpression expr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DynamicExpression(Script S, string strExpr, DynValue constant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Evaluate(ScriptExecutionContext context = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SymbolRef FindSymbol(ScriptExecutionContext context) => throw null;

    public Script OwnerScript
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsConstant() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetHashCode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Equals(object obj) => throw null;
  }
}
