// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.ScrollbarExtended
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Messages;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
  public class ScrollbarExtended : 
    Scrollbar,
    IPointerDownHandler,
    IEventSystemHandler,
    IPointerUpHandler
  {
    public SelectedDiscoverableMessage SliderReleasedMessageType;
    public readonly ScrollbarExtended.IsPointerDownChangedEvent onIsPointerDownChanged;
    public readonly ScrollbarExtended.DragPositionChangedEvent onDragPositionChanged;
    public readonly ScrollbarExtended.OnValueChangeWithoutPointer onValueDiffWithoutPointer;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerDown(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnPointerUp(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScrollbarExtended() => throw null;

    public class IsPointerDownChangedEvent : UnityEvent<bool>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public IsPointerDownChangedEvent() => throw null;
    }

    public class DragPositionChangedEvent : UnityEvent
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public DragPositionChangedEvent() => throw null;
    }

    public class OnValueChangeWithoutPointer : UnityEvent<float>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public OnValueChangeWithoutPointer() => throw null;
    }
  }
}
