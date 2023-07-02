// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Statement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
