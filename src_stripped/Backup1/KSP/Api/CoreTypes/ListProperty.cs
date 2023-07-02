// Decompiled with JetBrains decompiler
// Type: KSP.Api.CoreTypes.ListProperty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KSP.Api.CoreTypes
{
  public class ListProperty : IListProperty, IList, ICollection, IEnumerable
  {
    private int pauseCounter;
    protected IBindingList backingList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ListProperty(IBindingList backingList = null) => throw null;

    protected virtual bool ShouldRaiseChangeEvent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public object this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool RaiseIncidentalEvents
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool RaiseListChangedEvents
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PushPauseEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PopPauseEvents() => throw null;

    public bool AllowInsert
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool AllowRemove
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool AllowMove
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool AllowTransfer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsFixedSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsReadOnly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public event KSP.Api.ListChangedEventHandler ListChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int Add(object value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(object value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int IndexOf(object value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Insert(int index, object value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MoveElement(int indexFrom, int indexTo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(object value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAt(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TransferElement(IListProperty newList, int indexFrom, int indexTo) => throw null;
  }
}
