// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Statements.ForEachLoopStatement
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
  internal class ForEachLoopStatement : Statement
  {
    private RuntimeScopeBlock m_StackFrame;
    private SymbolRef[] m_Names;
    private IVariable[] m_NameExps;
    private Expression m_RValues;
    private Statement m_Block;
    private SourceRef m_RefFor;
    private SourceRef m_RefEnd;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ForEachLoopStatement(
      ScriptLoadingContext lcontext,
      Token firstNameToken,
      Token forToken)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Compile(ByteCode bc) => throw null;
  }
}
