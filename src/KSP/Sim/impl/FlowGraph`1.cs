// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.FlowGraph`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
