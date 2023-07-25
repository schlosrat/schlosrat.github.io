// Decompiled with JetBrains decompiler
// Type: XSelectable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;

public class XSelectable : 
  UIBehaviour,
  IEventSystemHandler,
  IPointerEnterHandler,
  IPointerExitHandler,
  IPointerDownHandler,
  IPointerUpHandler,
  ISelectHandler,
  IDeselectHandler,
  IMoveHandler
{
  private bool hover;
  private bool down;
  private bool selected;

  public event Callback<XSelectable, PointerEventData> onPointerEnter
  {
    [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
  }

  public event Callback<XSelectable, PointerEventData> onPointerExit
  {
    [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
  }

  public event Callback<XSelectable, PointerEventData> onPointerDown
  {
    [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
  }

  public event Callback<XSelectable, PointerEventData> onPointerUp
  {
    [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
  }

  public event Callback<XSelectable, BaseEventData> onSelect
  {
    [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
  }

  public event Callback<XSelectable, BaseEventData> onDeselect
  {
    [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
  }

  public event Callback<XSelectable, AxisEventData> onMove
  {
    [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
  }

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
  protected override void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnPointerEnter(PointerEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnPointerExit(PointerEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnPointerDown(PointerEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnPointerUp(PointerEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnMove(AxisEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnSelect(BaseEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnDeselect(BaseEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Clear() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public XSelectable() => throw null;
}
