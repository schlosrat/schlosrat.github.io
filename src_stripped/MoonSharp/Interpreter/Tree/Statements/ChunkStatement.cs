// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Statements.ChunkStatement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Tree.Statements
{
  internal class ChunkStatement : Statement, IClosureBuilder
  {
    private Statement m_Block;
    private RuntimeScopeFrame m_StackFrame;
    private SymbolRef m_Env;
    private SymbolRef m_VarArgs;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChunkStatement(ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Compile(ByteCode bc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SymbolRef CreateUpvalue(BuildTimeScope scope, SymbolRef symbol) => throw null;
  }
}
