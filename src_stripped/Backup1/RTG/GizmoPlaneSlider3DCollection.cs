// Decompiled with JetBrains decompiler
// Type: RTG.GizmoPlaneSlider3DCollection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoPlaneSlider3DCollection
  {
    private List<GizmoPlaneSlider3D> _sliders;
    private Dictionary<int, GizmoPlaneSlider3D> _handleIdToSlider;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoPlaneSlider3D this[int id]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(GizmoPlaneSlider3D slider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(int sliderHandleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(GizmoPlaneSlider3D slider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(GizmoPlaneSlider3D slider) => throw null;

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
    public void SetVisible(bool isVisible, bool includeBorder) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBorderVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetHoverable(bool isHoverable, bool includeBorder) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBorderHoverable(bool isHoverable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<GizmoPlaneSlider3D> GetRenderSortedSliders(Camera renderCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoPlaneSlider3DCollection() => throw null;
  }
}
