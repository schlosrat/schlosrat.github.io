// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.CircularBuffer`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EdyCommonTools
{
  public class CircularBuffer<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection
  {
    private int m_capacity;
    private int m_size;
    private int m_head;
    private int m_tail;
    private T[] m_buffer;
    [NonSerialized]
    private object syncRoot;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CircularBuffer(int m_capacity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CircularBuffer(int capacity, bool allowOverflow) => throw null;

    public bool allowOverflow
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int capacity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int size
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int IndexOf(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAt(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int Put(T[] src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int Put(T[] src, int srcOffset, int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Put(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Skip(int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T[] Get(int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int Get(T[] dst) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int Get(T[] dst, int dstOffset, int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T Get() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T Peek(int offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T Head() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T Tail() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(T[] array) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(T[] array, int arrayIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(int index, T[] array, int arrayIndex, int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator<T> GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T[] GetBuffer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T[] ToArray() => throw null;

    int ICollection<T>.Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    bool ICollection<T>.IsReadOnly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void ICollection<T>.Add(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    bool ICollection<T>.Remove(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    IEnumerator<T> IEnumerable<T>.GetEnumerator() => throw null;

    int ICollection.Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    bool ICollection.IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    object ICollection.SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void ICollection.CopyTo(Array array, int arrayIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    IEnumerator IEnumerable.GetEnumerator() => throw null;

    public int headIdx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int tailIdx
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }
  }
}
