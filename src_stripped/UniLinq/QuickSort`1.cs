// Decompiled with JetBrains decompiler
// Type: UniLinq.QuickSort`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UniLinq
{
  internal class QuickSort<TElement>
  {
    private TElement[] elements;
    private int[] indexes;
    private SortContext<TElement> context;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private QuickSort(IEnumerable<TElement> source, SortContext<TElement> context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int[] CreateIndexes(int length) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PerformSort() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TElement> Sort(
      IEnumerable<TElement> source,
      SortContext<TElement> context)
    {
      throw null;
    }
  }
}
