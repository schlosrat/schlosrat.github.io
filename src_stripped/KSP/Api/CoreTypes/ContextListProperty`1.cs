// Decompiled with JetBrains decompiler
// Type: KSP.Api.CoreTypes.ContextListProperty`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Api.CoreTypes
{
  public class ContextListProperty<T> : 
    IList<T>,
    ICollection<T>,
    IEnumerable<T>,
    IEnumerable,
    IReadOnlyList<T>,
    IReadOnlyCollection<T>,
    IContextListProperty
    where T : IDataContext
  {
    private List<T> list;

    public event Action OnListChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public IDataContextReadonly HierarchyParent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IReadOnlyList<IDataContextReadonly> Data
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsReadOnly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    IDataContextReadonly IContextListProperty.this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public T this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContextListProperty(IDataContextReadonly source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContextListProperty(IDataContextReadonly source, IEnumerable<T> values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(int index, T value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetInternal(int index, T value, bool fireEvent = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddInternal(T item, bool fireEvent = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Push(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PushInternal(T item, bool fireEvent = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T Pop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T PopInternal(bool fireEvent = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddRange(IEnumerable<T> collection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddRangeInternal(IEnumerable<T> collection, bool fireEvent = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearInternal(bool fireEvent = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(T[] array, int arrayIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator<T> GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int IndexOf(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Insert(int index, T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InsertInternal(int index, T item, bool fireEvent = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Remove(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveInternal(T item, bool fireEvent = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAt(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAtInternal(int index, bool fireEvent = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    IEnumerator IEnumerable.GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Sort(Comparison<T> comparison) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SortInternal(Comparison<T> comparison, bool fireEvent = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Sort(int index, int count, IComparer<T> comparer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SortInternal(int index, int count, IComparer<T> comparer, bool fireEvent = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Sort() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SortInternal(bool fireEvent = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Sort(IComparer<T> comparer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SortInternal(IComparer<T> comparer, bool fireEvent = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Move(int indexFrom, int indexTo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MoveInternal(int indexFrom, int indexTo, bool fireEvent = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IDataContextReadonly GetIndexedElement(int index, string indexKey = "index") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InvokeOnListChanged(bool fireEvent = true) => throw null;
  }
}
