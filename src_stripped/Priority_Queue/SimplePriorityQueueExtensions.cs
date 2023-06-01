// Decompiled with JetBrains decompiler
// Type: Priority_Queue.SimplePriorityQueueExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace Priority_Queue
{
  public static class SimplePriorityQueueExtensions
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void EnqueueOrUpdate<TItem, TPriority>(
      this SimplePriorityQueue<TItem, TPriority> queue,
      TItem item,
      TPriority priority)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryDequeue<TItem, TPriority>(
      this SimplePriorityQueue<TItem, TPriority> queue,
      out TItem item,
      out TPriority priority)
    {
      throw null;
    }
  }
}
