// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Expressions.IndexExpression
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Tree.Expressions
{
  internal class IndexExpression : Expression, IVariable
  {
    private Expression m_BaseExp;
    private Expression m_IndexExp;
    private string m_Name;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IndexExpression(Expression baseExp, Expression indexExp, ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IndexExpression(Expression baseExp, string name, ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Compile(ByteCode bc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CompileAssignment(ByteCode bc, int stackofs, int tupleidx) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DynValue Eval(ScriptExecutionContext context) => throw null;
  }
}
