// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Execution.Scopes.BuildTimeScopeBlock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Tree.Statements;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Execution.Scopes
{
  internal class BuildTimeScopeBlock
  {
    private Dictionary<string, SymbolRef> m_DefinedNames;
    private List<GotoStatement> m_PendingGotos;
    private Dictionary<string, LabelStatement> m_LocalLabels;
    private string m_LastDefinedName;

    internal BuildTimeScopeBlock Parent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    internal List<BuildTimeScopeBlock> ChildNodes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    internal RuntimeScopeBlock ScopeBlock
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void Rename(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal BuildTimeScopeBlock(BuildTimeScopeBlock parent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal BuildTimeScopeBlock AddChild() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal SymbolRef Find(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal SymbolRef Define(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal int ResolveLRefs(BuildTimeScopeFrame buildTimeScopeFrame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void DefineLabel(LabelStatement label) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void RegisterGoto(GotoStatement gotostat) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void ResolveGotos() => throw null;
  }
}
