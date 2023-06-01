// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Expressions.TableConstructor
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
  internal class TableConstructor : Expression
  {
    private bool m_Shared;
    private List<Expression> m_PositionalValues;
    private List<KeyValuePair<Expression, Expression>> m_CtorArgs;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TableConstructor(ScriptLoadingContext lcontext, bool shared) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MapField(ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StructField(ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ArrayField(ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Compile(ByteCode bc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DynValue Eval(ScriptExecutionContext context) => throw null;
  }
}
