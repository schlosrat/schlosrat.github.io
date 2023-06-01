// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Loop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Tree
{
  internal class Loop : ILoop
  {
    public RuntimeScopeBlock Scope;
    public List<Instruction> BreakJumps;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CompileBreak(ByteCode bc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsBoundary() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Loop() => throw null;
  }
}
