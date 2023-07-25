// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.DataStructs.LinkedListIndex`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.DataStructs
{
  internal class LinkedListIndex<TKey, TValue>
  {
    private LinkedList<TValue> m_LinkedList;
    private Dictionary<TKey, LinkedListNode<TValue>> m_Map;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LinkedListIndex(LinkedList<TValue> linkedList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LinkedListNode<TValue> Find(TKey key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TValue Set(TKey key, TValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(TKey key, TValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Remove(TKey key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsKey(TKey key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;
  }
}
