// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.DataStructs.Slice`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.DataStructs
{
  internal class Slice<T> : IEnumerable<T>, IEnumerable, IList<T>, ICollection<T>
  {
    private IList<T> m_SourceList;
    private int m_From;
    private int m_Length;
    private bool m_Reversed;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Slice(IList<T> list, int from, int length, bool reversed) => throw null;

    public T this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int From
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool Reversed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int CalcRealIndex(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator<T> GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    IEnumerator IEnumerable.GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T[] ToArray() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<T> ToList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int IndexOf(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Insert(int index, T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAt(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(T[] array, int arrayIndex) => throw null;

    public bool IsReadOnly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Remove(T item) => throw null;
  }
}
