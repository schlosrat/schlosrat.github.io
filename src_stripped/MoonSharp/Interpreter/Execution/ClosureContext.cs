// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Execution.ClosureContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
