// Decompiled with JetBrains decompiler
// Type: UniLinq.Grouping`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UniLinq
{
  internal class Grouping<K, T> : IGrouping<K, T>, IEnumerable<T>, IEnumerable
  {
    private K key;
    private IEnumerable<T> group;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Grouping(K key, IEnumerable<T> group) => throw null;

    public K Key
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator<T> GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    IEnumerator IEnumerable.GetEnumerator() => throw null;
  }
}
