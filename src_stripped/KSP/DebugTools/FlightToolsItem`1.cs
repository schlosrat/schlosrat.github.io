// Decompiled with JetBrains decompiler
// Type: KSP.DebugTools.FlightToolsItem`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.DebugTools
{
  internal abstract class FlightToolsItem<T> : 
    MonoBehaviour,
    IPointerEnterHandler,
    IEventSystemHandler,
    IPointerExitHandler
  {
    protected T _model;
    public Action DestroyButtonClicked;
    public Action<FlightToolsItem<T>> PointerEntered;
    public Action<FlightToolsItem<T>> PointerExited;

    public T Model
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Refresh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void SyncTo(T model) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IPointerExitHandler.OnPointerExit(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected FlightToolsItem() => throw null;
  }
}
