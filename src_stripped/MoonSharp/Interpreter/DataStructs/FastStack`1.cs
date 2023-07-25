// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.DataStructs.FastStack`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.DataStructs
{
  internal class FastStack<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
  {
    private T[] m_Storage;
    private int m_HeadIdx;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FastStack(int maxCapacity) => throw null;

    public T this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T Push(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Expand(int size) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Zero(int from, int to) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Zero(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T Peek(int idxofs = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(int idxofs, T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CropAtCount(int p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveLast(int cnt = 1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T Pop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    int IList<T>.IndexOf(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IList<T>.Insert(int index, T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IList<T>.RemoveAt(int index) => throw null;

    T IList<T>.this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void ICollection<T>.Add(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void ICollection<T>.Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    bool ICollection<T>.Contains(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void ICollection<T>.CopyTo(T[] array, int arrayIndex) => throw null;

    int ICollection<T>.Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    bool ICollection<T>.IsReadOnly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    bool ICollection<T>.Remove(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    IEnumerator<T> IEnumerable<T>.GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    IEnumerator IEnumerable.GetEnumerator() => throw null;
  }
}
