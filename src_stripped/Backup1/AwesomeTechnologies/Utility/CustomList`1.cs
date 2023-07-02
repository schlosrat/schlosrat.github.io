// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.CustomList`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Utility
{
  [Serializable]
  public class CustomList<T>
  {
    [SerializeField]
    public T[] Data;
    public int Count;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CustomList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CustomList(int capacity) => throw null;

    public T this[int i]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResizeArray() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T First() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T Last() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddStart(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Insert(T item, int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T RemoveStart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T RemoveAt(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T Remove(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T RemoveEnd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(T item) => throw null;
  }
}
