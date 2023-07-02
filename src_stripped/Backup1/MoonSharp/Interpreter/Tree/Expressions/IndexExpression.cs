// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Expressions.IndexExpression
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
