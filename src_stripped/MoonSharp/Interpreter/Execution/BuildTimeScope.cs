// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Execution.BuildTimeScope
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter.Execution.Scopes;
using MoonSharp.Interpreter.Tree.Statements;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Execution
{
  internal class BuildTimeScope
  {
    private List<BuildTimeScopeFrame> m_Frames;
    private List<IClosureBuilder> m_ClosureBuilders;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PushFunction(IClosureBuilder closureBuilder, bool hasVarArgs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PushBlock() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RuntimeScopeBlock PopBlock() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RuntimeScopeFrame PopFunction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SymbolRef Find(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SymbolRef CreateGlobalReference(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ForceEnvUpValue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SymbolRef CreateUpValue(
      BuildTimeScope buildTimeScope,
      SymbolRef symb,
      int closuredFrame,
      int currentFrame)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SymbolRef DefineLocal(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SymbolRef TryDefineLocal(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CurrentFunctionHasVarArgs() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void DefineLabel(LabelStatement label) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void RegisterGoto(GotoStatement gotostat) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BuildTimeScope() => throw null;
  }
}
