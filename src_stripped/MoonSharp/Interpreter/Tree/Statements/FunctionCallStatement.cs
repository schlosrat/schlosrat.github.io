// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Statements.FunctionCallStatement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using MoonSharp.Interpreter.Tree.Expressions;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Tree.Statements
{
  internal class FunctionCallStatement : Statement
  {
    private FunctionCallExpression m_FunctionCallExpression;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FunctionCallStatement(
      ScriptLoadingContext lcontext,
      FunctionCallExpression functionCallExpression)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Compile(ByteCode bc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveBreakpointStop(Instruction instruction) => throw null;
  }
}
