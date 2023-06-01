// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Statements.ForLoopStatement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Tree.Statements
{
  internal class ForLoopStatement : Statement
  {
    private RuntimeScopeBlock m_StackFrame;
    private Statement m_InnerBlock;
    private SymbolRef m_VarName;
    private Expression m_Start;
    private Expression m_End;
    private Expression m_Step;
    private SourceRef m_RefFor;
    private SourceRef m_RefEnd;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ForLoopStatement(ScriptLoadingContext lcontext, Token nameToken, Token forToken) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Compile(ByteCode bc) => throw null;
  }
}
