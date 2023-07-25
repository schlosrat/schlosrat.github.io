// Decompiled with JetBrains decompiler
// Type: KSP.FixedQueue`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP
{
  public class FixedQueue<T> : Queue<T>
  {
    private int maxCount;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private FixedQueue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FixedQueue(int maxCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FixedQueue(int maxCount, IEnumerable<T> collection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public new void Enqueue(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMaxCount(int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShrinkToMaxCount() => throw null;
  }
}
