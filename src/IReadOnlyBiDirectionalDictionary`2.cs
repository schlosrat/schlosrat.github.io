// Decompiled with JetBrains decompiler
// Type: IReadOnlyBiDirectionalDictionary`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
