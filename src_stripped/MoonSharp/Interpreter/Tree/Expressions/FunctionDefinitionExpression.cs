// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Expressions.FunctionDefinitionExpression
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Tree.Expressions
{
  internal class FunctionDefinitionExpression : Expression, IClosureBuilder
  {
    private SymbolRef[] m_ParamNames;
    private Statement m_Statement;
    private RuntimeScopeFrame m_StackFrame;
    private List<SymbolRef> m_Closure;
    private bool m_HasVarArgs;
    private Instruction m_ClosureInstruction;
    private bool m_UsesGlobalEnv;
    private SymbolRef m_Env;
    private SourceRef m_Begin;
    private SourceRef m_End;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FunctionDefinitionExpression(ScriptLoadingContext lcontext, bool usesGlobalEnv) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FunctionDefinitionExpression(
      ScriptLoadingContext lcontext,
      bool pushSelfParam,
      bool isLambda)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private FunctionDefinitionExpression(
      ScriptLoadingContext lcontext,
      bool pushSelfParam,
      bool usesGlobalEnv,
      bool isLambda)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Statement CreateLambdaBody(ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Statement CreateBody(ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<string> BuildParamList(
      ScriptLoadingContext lcontext,
      bool pushSelfParam,
      Token openBracketToken,
      bool isLambda)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SymbolRef[] DefineArguments(List<string> paramnames, ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SymbolRef CreateUpvalue(BuildTimeScope scope, SymbolRef symbol) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DynValue Eval(ScriptExecutionContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int CompileBody(ByteCode bc, string friendlyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int Compile(ByteCode bc, Func<int> afterDecl, string friendlyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Compile(ByteCode bc) => throw null;
  }
}
