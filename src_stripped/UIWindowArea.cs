// Decompiled with JetBrains decompiler
// Type: UIWindowArea
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
