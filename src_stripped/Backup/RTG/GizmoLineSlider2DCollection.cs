// Decompiled with JetBrains decompiler
// Type: RTG.GizmoLineSlider2DCollection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoLineSlider2DCollection
  {
    private List<GizmoLineSlider2D> _sliders;
    private Dictionary<int, GizmoLineSlider2D> _handleIdToSlider;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoLineSlider2D this[int id]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(GizmoLineSlider2D slider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(int sliderHandleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsCapId(int capHandleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(GizmoLineSlider2D slider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(GizmoLineSlider2D slider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Make2DHoverPriorityLowerThan(Priority priority) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Make2DHoverPriorityHigherThan(Priority priority) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSnapEnabled(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVisible(bool visible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set2DCapsVisible(bool visible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOffsetDragOrigin(Vector3 dragOrigin) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Render(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoLineSlider2DCollection() => throw null;
  }
}
