// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Statement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter.Execution;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Tree
{
  internal abstract class Statement : NodeBase
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Statement(ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected static Statement CreateStatement(ScriptLoadingContext lcontext, out bool forceLast) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Statement DispatchForLoopStatement(ScriptLoadingContext lcontext) => throw null;
  }
}
