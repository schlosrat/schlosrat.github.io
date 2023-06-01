// Decompiled with JetBrains decompiler
// Type: UIWindowArea
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIWindowArea : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler
{
  public bool moveWindow;
  public bool resizeWindow;
  public UIWindow.ResizeWidth resizeWidth;
  public UIWindow.ResizeHeight resizeHeight;
  public RectTransform targetWindow;
  private UIWindow uiWindow;
  private float originalDelay;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnBeginDrag(PointerEventData eventData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual void OnDrag(PointerEventData data) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual void OnMove(PointerEventData data) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual void OnResize(PointerEventData data) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public UIWindowArea() => throw null;
}
