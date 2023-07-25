// Decompiled with JetBrains decompiler
// Type: UniLinq.Lookup`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UniLinq
{
  public class Lookup<TKey, TElement> : 
    IEnumerable<IGrouping<TKey, TElement>>,
    IEnumerable,
    ILookup<TKey, TElement>
  {
    private IGrouping<TKey, TElement> nullGrouping;
    private Dictionary<TKey, IGrouping<TKey, TElement>> groups;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IEnumerable<TElement> this[TKey key]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Lookup(Dictionary<TKey, List<TElement>> lookup, IEnumerable<TElement> nullKeyElements) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<TResult> ApplyResultSelector<TResult>(
      Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(TKey key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    IEnumerator IEnumerable.GetEnumerator() => throw null;
  }
}
