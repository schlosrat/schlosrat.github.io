// Decompiled with JetBrains decompiler
// Type: KSP.FixedQueue`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
