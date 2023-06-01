// Decompiled with JetBrains decompiler
// Type: IBiDirectionalDictionary`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;

public interface IBiDirectionalDictionary<TKey, TValue> : 
  IDictionary<TKey, TValue>,
  ICollection<KeyValuePair<TKey, TValue>>,
  IEnumerable<KeyValuePair<TKey, TValue>>,
  IEnumerable,
  IReadOnlyBiDirectionalDictionary<TKey, TValue>,
  IReadOnlyDictionary<TKey, TValue>,
  IReadOnlyCollection<KeyValuePair<TKey, TValue>>
{
  new TValue this[TKey key] { get; set; }

  new ICollection<TKey> Keys { get; }

  new ICollection<TValue> Values { get; }

  new int Count { get; }

  void Set(TKey key, TValue value);

  bool TryAdd(TKey key, TValue value);

  bool TryAdd(KeyValuePair<TKey, TValue> pair);

  bool RemoveByValue(TValue value);

  bool RemoveByKey(TKey key);

  new bool ContainsKey(TKey key);

  new bool TryGetValue(TKey key, out TValue value);
}
