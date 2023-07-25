// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Statements.ScopeBlockStatement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Tree.Statements
{
  internal class ScopeBlockStatement : Statement
  {
    private Statement m_Block;
    private RuntimeScopeBlock m_StackFrame;
    private SourceRef m_Do;
    private SourceRef m_End;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScopeBlockStatement(ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Compile(ByteCode bc) => throw null;
  }
}
