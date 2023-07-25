// Decompiled with JetBrains decompiler
// Type: IReadOnlyBiDirectionalDictionary`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
