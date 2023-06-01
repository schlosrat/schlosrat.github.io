// Decompiled with JetBrains decompiler
// Type: RTG.GizmoLineSlider3DCollection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoLineSlider3DCollection
  {
    private List<GizmoLineSlider3D> _sliders;
    private Dictionary<int, GizmoLineSlider3D> _handleIdToSlider;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoLineSlider3D this[int id]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(GizmoLineSlider3D slider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(int sliderHandleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsCapId(int capHandleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(GizmoLineSlider3D slider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(GizmoLineSlider3D slider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyZoomFactor(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetZoomFactorTransform(GizmoTransform zoomFactorTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Make3DHoverPriorityLowerThan(Priority priority) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Make3DHoverPriorityHigherThan(Priority priority) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSnapEnabled(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVisible(bool visible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set3DCapsVisible(bool visible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDragChannel(GizmoDragChannel dragChannel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterScalerHandle(int handleId, IEnumerable<int> scaleDragAxisIndices) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<GizmoLineSlider3D> GetRenderSortedSliders(Camera renderCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoLineSlider3DCollection() => throw null;
  }
}
