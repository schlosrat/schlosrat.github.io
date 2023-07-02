// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSP2ResizableWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.UI
{
  public class KSP2ResizableWindow : 
    MonoBehaviour,
    IPointerDownHandler,
    IEventSystemHandler,
    IDragHandler
  {
    [SerializeField]
    [Header("Min/Max sizes")]
    private Vector2 minSize;
    [SerializeField]
    private Vector2 maxSize;
    [Header("Resize cursor")]
    [SerializeField]
    private Texture2D resizeCursor;
    private RectTransform uiPanelTransform;
    private Vector2 currentPointerPosition;
    private Vector2 previousPointerPosition;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerEnter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerExit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerDown(PointerEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDrag(PointerEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSP2ResizableWindow() => throw null;
  }
}
