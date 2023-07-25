// Decompiled with JetBrains decompiler
// Type: KSP.Utilities.LRUCache`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Utilities
{
  public class LRUCache<T>
  {
    private int _capacity;
    private Dictionary<string, KeyValuePair<string, T>> _cache;
    private List<KeyValuePair<string, T>> _itemList;

    public int Capacity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LRUCache(int capacity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddOrUpdate(string key, T val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetValue(string key, out T val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Touch(KeyValuePair<string, T> item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private KeyValuePair<string, T> EvictOldest() => throw null;
  }
}
