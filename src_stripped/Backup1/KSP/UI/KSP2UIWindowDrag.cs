// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSP2UIWindowDrag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
