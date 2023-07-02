// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.FlowGraph`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
