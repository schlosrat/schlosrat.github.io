// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.DataStructs.LinkedListIndex`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
