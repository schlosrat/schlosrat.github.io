// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.ObjectAssemblyUIDragArea2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Messages;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
  [RequireComponent(typeof (RectTransform), typeof (RawImage))]
  public class ObjectAssemblyUIDragArea2D : 
    Selectable,
    IDragHandler,
    IEventSystemHandler,
    IInitializePotentialDragHandler,
    IEndDragHandler,
    IPointerClickHandler
  {
    [Header("Icon")]
    public RectTransform iconTransform;
    public RectTransform iconAreaTransform;
    [Space(5f)]
    private Vector2 point;
    public ObjectAssemblyUIDragArea2D.DragArea2DPointEvent onValueChanged;
    public bool PublishMessages;
    public SelectedDiscoverableMessage SliderReleasedMessageType;

    public Vector2 Point
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateIconPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnDrag(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(Vector2 value, bool sendCallback = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnInitializePotentialDrag(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEndDrag(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerClick(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetNewValueFromMousePosition(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyUIDragArea2D() => throw null;

    public class DragArea2DPointEvent : UnityEvent<Vector2>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public DragArea2DPointEvent() => throw null;
    }
  }
}
