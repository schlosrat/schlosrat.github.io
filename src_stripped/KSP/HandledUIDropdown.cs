// Decompiled with JetBrains decompiler
// Type: KSP.HandledUIDropdown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP
{
  public class HandledUIDropdown : Dropdown
  {
    public Action<GameObject> onDropdownCreate;
    public Action<GameObject> onItemCreate;
    public Func<BaseEventData, bool> handleSubmit;
    public Func<BaseEventData, bool> handleCancel;
    public Func<BaseEventData, bool> handleSelect;
    public Func<BaseEventData, bool> handleDeselect;
    public Func<PointerEventData, bool> handlePointerUp;
    public Func<PointerEventData, bool> handlePointerDown;
    public Func<PointerEventData, bool> handlePointerClick;
    public Func<PointerEventData, bool> handlePointerEnter;
    public Func<PointerEventData, bool> handlePointerExit;
    public Func<AxisEventData, bool> handleMove;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override GameObject CreateDropdownList(GameObject template) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override Dropdown.DropdownItem CreateItem(Dropdown.DropdownItem itemTemplate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void ForwardEvent<T>(T eventData, Func<T, bool> handler, Action<T> callback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnSelect(BaseEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDeselect(BaseEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnSubmit(BaseEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnCancel(BaseEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerDown(PointerEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerUp(PointerEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerClick(PointerEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerEnter(PointerEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerExit(PointerEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnMove(AxisEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HandledUIDropdown() => throw null;
  }
}
