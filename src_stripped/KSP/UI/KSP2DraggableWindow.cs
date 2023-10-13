// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSP2DraggableWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.UI
{
  [Obsolete("Please use KSP2UIWindow for ant new windows and be wary of editing this class", false)]
  public class KSP2DraggableWindow : 
    MonoBehaviour,
    IPointerDownHandler,
    IEventSystemHandler,
    IDragHandler
  {
    [SerializeField]
    [Header("UI Panel Root")]
    private RectTransform uiPanelRootTransform;
    private RectTransform uiPanelTransform;
    private RectTransform canvasTransform;
    private Vector2 mousePointerOffset;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDrag(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerDown(PointerEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSP2DraggableWindow() => throw null;
  }
}
