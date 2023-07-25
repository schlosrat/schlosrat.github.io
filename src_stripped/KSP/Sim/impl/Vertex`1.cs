// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.Vertex`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class Vertex<T>
  {
    public T Value
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public List<Vertex<T>> Connections
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vertex() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vertex(T value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vertex(IEnumerable<Vertex<T>> dependencies) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vertex(T value, IEnumerable<Vertex<T>> dependencies) => throw null;
  }
}
