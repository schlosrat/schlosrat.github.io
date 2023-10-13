// Decompiled with JetBrains decompiler
// Type: IReadOnlyBiDirectionalDictionary`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections;
using System.Collections.Generic;

public interface IReadOnlyBiDirectionalDictionary<TKey, TValue> : 
  IReadOnlyDictionary<TKey, TValue>,
  IEnumerable<KeyValuePair<TKey, TValue>>,
  IEnumerable,
  IReadOnlyCollection<KeyValuePair<TKey, TValue>>
{
  IReadOnlyDictionary<TKey, TValue> Forward { get; }

  IReadOnlyDictionary<TValue, TKey> Reverse { get; }

  bool ContainsValue(TValue value);

  bool TryGetKey(TValue value, out TKey key);
}
