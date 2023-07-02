// Decompiled with JetBrains decompiler
// Type: KSP.RingBuffer`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP
{
  public class RingBuffer<T> : IEnumerable<T>, IEnumerable
  {
    private T[] buffer;
    private int size;
    private int start;
    private int end;
    private bool allowOverwrite;

    public int Capacity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsEmpty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public T this[int i]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RingBuffer(int capacity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RingBuffer(int capacity, bool allowOverwrite) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Enqueue(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T Peek() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryPeek(out T result) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T Dequeue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryDequeue(out T result) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array dest, int destIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(T[] dest, int destIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator<T> GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    IEnumerator IEnumerable.GetEnumerator() => throw null;
  }
}
