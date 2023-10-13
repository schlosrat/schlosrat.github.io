// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.DragArea2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
  public class DragArea2D : RawImage, IDragHandler, IEventSystemHandler, IPointerDownHandler
  {
    public DragArea2D.DragArea2DPointEvent onPointChanged;
    private Vector2 point;
    public RectTransform indicator;

    public Vector2 Size
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector2 Point
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector2 PointInWorld
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDrag(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerDown(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void UpdatePosition2D(Vector2 cursorWorldPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(Vector2 value, bool skipEvent = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DragArea2D() => throw null;

    public class DragArea2DPointEvent : UnityEvent<Vector2>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public DragArea2DPointEvent() => throw null;
    }
  }
}
