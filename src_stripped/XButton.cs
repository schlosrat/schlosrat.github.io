// Decompiled with JetBrains decompiler
// Type: XButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class XButton : Button
{
  private bool hover;
  private bool down;
  private bool selected;

  public event Callback<XButton, PointerEventData> onPointerEnter
  {
    [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
  }

  public event Callback<XButton, PointerEventData> onPointerExit
  {
    [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
  }

  public event Callback<XButton, PointerEventData> onPointerDown
  {
    [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
  }

  public event Callback<XButton, PointerEventData> onPointerUp
  {
    [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
  }

  public event Callback<XButton, BaseEventData> onSelect
  {
    [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
  }

  public event Callback<XButton, BaseEventData> onDeselect
  {
    [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
  }

  public event Callback<XButton, AxisEventData> onMove
  {
    [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static XButton Create(GameObject host, XGraphic tgtGraphic) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Terminate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void Awake() => throw null;

  public bool Hover
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public bool Down
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public bool Selected
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnPointerEnter(PointerEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnPointerExit(PointerEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnPointerDown(PointerEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnPointerUp(PointerEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnSelect(BaseEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnDeselect(BaseEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnMove(AxisEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public XButton() => throw null;
}
