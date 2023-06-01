// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Execution.ClosureContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Execution
{
  internal class ClosureContext : List<DynValue>
  {
    public string[] Symbols
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ClosureContext(SymbolRef[] symbols, IEnumerable<DynValue> values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ClosureContext() => throw null;
  }
}
