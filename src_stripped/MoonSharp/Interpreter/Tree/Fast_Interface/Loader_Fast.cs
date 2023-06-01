// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Fast_Interface.Loader_Fast
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using MoonSharp.Interpreter.Tree.Expressions;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Tree.Fast_Interface
{
  internal static class Loader_Fast
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static DynamicExprExpression LoadDynamicExpr(Script script, SourceCode source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static ScriptLoadingContext CreateLoadingContext(Script script, SourceCode source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int LoadChunk(Script script, SourceCode source, ByteCode bytecode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int LoadFunction(
      Script script,
      SourceCode source,
      ByteCode bytecode,
      bool usesGlobalEnv)
    {
      throw null;
    }
  }
}
