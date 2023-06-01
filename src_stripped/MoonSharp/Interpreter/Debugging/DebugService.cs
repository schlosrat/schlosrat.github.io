// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Debugging.DebugService
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter.Execution.VM;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Debugging
{
  public sealed class DebugService : IScriptPrivateResource
  {
    private Processor m_Processor;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DebugService(Script script, Processor processor) => throw null;

    public Script OwnerScript
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HashSet<int> ResetBreakPoints(SourceCode src, HashSet<int> lines) => throw null;
  }
}
