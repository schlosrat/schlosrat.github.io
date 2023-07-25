// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.FlowGraph`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class FlowGraph<T>
  {
    public List<Vertex<T>> graph;
    public Dictionary<T, Vertex<T>> lookup;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlowGraph() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vertex<T> Add(T part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vertex<T> GetPartVertex(T part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;
  }
}
