// Decompiled with JetBrains decompiler
// Type: ListDictionary`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[Serializable]
public class ListDictionary<TKey, TValue>
{
  private Dictionary<TKey, List<TValue>> dict;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ListDictionary() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ListDictionary(ListDictionary<TKey, TValue> old, bool shallow = true) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Clear() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool Add(TKey key, TValue val) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool Remove(TKey key, TValue val) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool Remove(TKey key) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool TryGetValue(TKey key, out List<TValue> val) => throw null;

  public Dictionary<TKey, List<TValue>>.KeyCollection Keys
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public Dictionary<TKey, List<TValue>>.ValueCollection Values
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Dictionary<TKey, List<TValue>>.Enumerator GetEnumerator() => throw null;

  public List<TValue> this[TKey key]
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }
}
