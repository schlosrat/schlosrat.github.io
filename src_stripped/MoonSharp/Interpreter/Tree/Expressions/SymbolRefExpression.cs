// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Expressions.SymbolRefExpression
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Tree.Expressions
{
  internal class SymbolRefExpression : Expression, IVariable
  {
    private SymbolRef m_Ref;
    private string m_VarName;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SymbolRefExpression(Token T, ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SymbolRefExpression(ScriptLoadingContext lcontext, SymbolRef refr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Compile(ByteCode bc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CompileAssignment(ByteCode bc, int stackofs, int tupleidx) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DynValue Eval(ScriptExecutionContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override SymbolRef FindDynamic(ScriptExecutionContext context) => throw null;
  }
}
