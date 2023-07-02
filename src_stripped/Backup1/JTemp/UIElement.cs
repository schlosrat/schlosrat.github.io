// Decompiled with JetBrains decompiler
// Type: JTemp.UIElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace JTemp
{
  public class UIElement : 
    MonoBehaviour,
    IComparable<UIElement>,
    IBeginDragHandler,
    IEventSystemHandler,
    IDragHandler,
    IEndDragHandler
  {
    public Action OnVisibilityChanged;
    public string[] uiTags;
    private UICluster cluster;
    private Graphic[] graphics;
    private bool visible;
    public bool canDrag;
    public UIContainer[] dragZones;
    private bool previousVisibility;
    private Vector2 startDif;
    private Vector2 startPos;
    private Transform startParent;
    private UIContainer startContainer;

    public bool Visible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void GetComponents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void SetCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnStart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetGraphics() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCluster(UICluster cls) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void VisibilityChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector2 ScreenSpacePixelPosition(RectTransform target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector2 ScreenSpaceNormalizedPosition(RectTransform target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int CompareTo(UIElement other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IDragHandler.OnDrag(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IEndDragHandler.OnEndDrag(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIElement() => throw null;
  }
}
