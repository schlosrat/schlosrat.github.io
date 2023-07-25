// Decompiled with JetBrains decompiler
// Type: KSP.OABOrderedDictionary`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP
{
  public class OABOrderedDictionary<TKey, TValue> : 
    IDictionary<TKey, TValue>,
    ICollection<KeyValuePair<TKey, TValue>>,
    IEnumerable<KeyValuePair<TKey, TValue>>,
    IEnumerable,
    IList<KeyValuePair<TKey, TValue>>
  {
    internal List<KeyValuePair<TKey, TValue>> internalList;
    internal Dictionary<TKey, TValue> internalDictionary;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal bool TryGetPairFromListByKey(
      TKey key,
      out KeyValuePair<TKey, TValue> valueFound,
      out int indexFound)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<KeyValuePair<TKey, TValue>> GetOrderedPairs() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<TKey> GetOrderedKeys() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<TValue> GetOrderedValues() => throw null;

    internal int ListCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    internal int DictionaryCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABOrderedDictionary() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABOrderedDictionary(IDictionary<TKey, TValue> dictionary) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABOrderedDictionary(IEqualityComparer<TKey> comparer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABOrderedDictionary(int capacity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABOrderedDictionary(IDictionary<TKey, TValue> values, IEqualityComparer<TKey> comparer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABOrderedDictionary(int capacity, IEqualityComparer<TKey> comparer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABOrderedDictionary(IEnumerable<KeyValuePair<TKey, TValue>> items) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(TKey key, TValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsKey(TKey key) => throw null;

    public ICollection<TKey> Keys
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Remove(TKey key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetValue(TKey key, out TValue value) => throw null;

    public ICollection<TValue> Values
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public TValue this[TKey key]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(KeyValuePair<TKey, TValue> item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(KeyValuePair<TKey, TValue> pair) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) => throw null;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsReadOnly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Remove(KeyValuePair<TKey, TValue> pair) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    IEnumerator IEnumerable.GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int IndexOf(KeyValuePair<TKey, TValue> item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Insert(int index, KeyValuePair<TKey, TValue> item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAt(int index) => throw null;

    public KeyValuePair<TKey, TValue> this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }
  }
}
