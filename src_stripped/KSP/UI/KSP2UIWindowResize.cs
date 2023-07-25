// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSP2UIWindowResize
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.UI
{
  public class KSP2UIWindowResize : 
    KSP2UIWindowControl,
    IDragHandler,
    IEventSystemHandler,
    IBeginDragHandler
  {
    [Header("Resize Stuff")]
    public bool ResizeEnabled;
    public KSP2UIWindow.ResizeWidthOptions ResizeWidth;
    public KSP2UIWindow.ResizeHeightOptions ResizeHeight;
    private Vector2 _deltaDiff;
    private Vector2 _offsetMinStart;
    private Vector2 _offsetMaxStart;
    private Vector2 _lastPointerPosition;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Oninitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnBeginDrag(PointerEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnDrag(PointerEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnResize(PointerEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSP2UIWindowResize() => throw null;
  }
}
