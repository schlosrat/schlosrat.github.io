// Decompiled with JetBrains decompiler
// Type: IBiDirectionalDictionary`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
