// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSP2UIWindowDrag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.UI
{
  public class KSP2UIWindowDrag : 
    KSP2UIWindowControl,
    IBeginDragHandler,
    IEventSystemHandler,
    IDragHandler
  {
    [Header("Move Stuff")]
    public bool MoveEnabled;
    private Vector2 _calculatedLocalPosition;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Oninitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnBeginDrag(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDrag(PointerEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMove(PointerEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSP2UIWindowDrag() => throw null;
  }
}
