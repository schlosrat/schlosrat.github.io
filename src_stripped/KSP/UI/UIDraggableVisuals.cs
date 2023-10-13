// Decompiled with JetBrains decompiler
// Type: KSP.UI.UIDraggableVisuals
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  [RequireComponent(typeof (LayoutGroup))]
  [RequireComponent(typeof (CanvasGroup))]
  public class UIDraggableVisuals : MonoBehaviour
  {
    [SerializeField]
    private UIDraggableVisuals.DragSourceVisualStyle _styleOriginWhileDragging;
    [SerializeField]
    private UIDraggableVisuals.DragElementVisualStyle _styleDragElementWhileDragging;
    [SerializeField]
    private bool _isDragging;
    public Action DragStarted;
    public Action DragEnded;

    public bool IsDragging
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public UIDraggableVisuals.DragSourceVisualStyle StyleOriginWhileDragging
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public UIDraggableVisuals.DragElementVisualStyle StyleDragElementWhileDragging
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateVisuals() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIDraggableVisuals() => throw null;

    public enum DragSourceVisualStyle
    {
      Hide,
      Collapse,
      Slide,
    }

    public enum DragElementVisualStyle
    {
      None,
      AlphaBlend,
    }
  }
}
