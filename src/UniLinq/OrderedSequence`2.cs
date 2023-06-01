// Decompiled with JetBrains decompiler
// Type: UniLinq.OrderedSequence`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UniLinq
{
  internal class OrderedSequence<TElement, TKey> : OrderedEnumerable<TElement>
  {
    private OrderedEnumerable<TElement> parent;
    private Func<TElement, TKey> selector;
    private IComparer<TKey> comparer;
    private SortDirection direction;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal OrderedSequence(
      IEnumerable<TElement> source,
      Func<TElement, TKey> key_selector,
      IComparer<TKey> comparer,
      SortDirection direction)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal OrderedSequence(
      OrderedEnumerable<TElement> parent,
      IEnumerable<TElement> source,
      Func<TElement, TKey> keySelector,
      IComparer<TKey> comparer,
      SortDirection direction)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IEnumerator<TElement> GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override SortContext<TElement> CreateContext(SortContext<TElement> current) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override IEnumerable<TElement> Sort(IEnumerable<TElement> source) => throw null;
  }
}
