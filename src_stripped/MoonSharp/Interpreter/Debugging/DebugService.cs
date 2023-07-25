// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Debugging.DebugService
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
