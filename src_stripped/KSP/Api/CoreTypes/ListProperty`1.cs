// Decompiled with JetBrains decompiler
// Type: KSP.Api.CoreTypes.ListProperty`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.Generic;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KSP.Api.CoreTypes
{
  public class ListProperty<T> : 
    ListProperty,
    IListProperty<T>,
    IListProperty,
    IList,
    ICollection,
    IEnumerable,
    IList<T>,
    ICollection<T>,
    IEnumerable<T>
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ListProperty(IBindingList backingList = null) => throw null;

    T IListProperty<T>.this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    T IList<T>.this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(T[] array, int arrayIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int IndexOf(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Insert(int index, T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Remove(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    IEnumerator<T> IEnumerable<T>.GetEnumerator() => throw null;
  }
}
