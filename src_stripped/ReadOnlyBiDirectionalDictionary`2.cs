// Decompiled with JetBrains decompiler
// Type: ReadOnlyBiDirectionalDictionary`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class ReadOnlyBiDirectionalDictionary<TKey, TValue> : 
  IBiDirectionalDictionary<TKey, TValue>,
  IDictionary<TKey, TValue>,
  ICollection<KeyValuePair<TKey, TValue>>,
  IEnumerable<KeyValuePair<TKey, TValue>>,
  IEnumerable,
  IReadOnlyBiDirectionalDictionary<TKey, TValue>,
  IReadOnlyDictionary<TKey, TValue>,
  IReadOnlyCollection<KeyValuePair<TKey, TValue>>
{
  private const string NAMEOF = "ReadOnlyBiDirectionalDictionary";
  private readonly BiDirectionalDictionary<TKey, TValue> _biDirectionalDictionary;

  public bool IsReadOnly
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public int Count
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public IReadOnlyDictionary<TKey, TValue> Forward
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public IReadOnlyDictionary<TValue, TKey> Reverse
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public ICollection<TKey> Keys
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public ICollection<TValue> Values
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public TValue this[TKey key]
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ReadOnlyBiDirectionalDictionary(
    BiDirectionalDictionary<TKey, TValue> biDirectionalDictionary)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool Contains(KeyValuePair<TKey, TValue> item) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool ContainsKey(TKey key) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool ContainsValue(TValue value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool TryGetValue(TKey key, out TValue value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool TryGetKey(TValue value, out TKey key) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  IEnumerator IEnumerable.GetEnumerator() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Clear() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Set(TKey key, TValue value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(KeyValuePair<TKey, TValue> item) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(TKey key, TValue value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool TryAdd(KeyValuePair<TKey, TValue> pair) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool TryAdd(TKey key, TValue value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool Remove(KeyValuePair<TKey, TValue> item) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool Remove(TKey key) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool RemoveByKey(TKey key) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool RemoveByValue(TValue value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static bool ThrowNotSupported([CallerMemberName] string memberName = "") => throw null;
}
