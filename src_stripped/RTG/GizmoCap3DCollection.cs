// Decompiled with JetBrains decompiler
// Type: RTG.GizmoCap3DCollection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoCap3DCollection
  {
    private List<GizmoCap3D> _caps;
    private Dictionary<int, GizmoCap3D> _handleIdToCap;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoCap3D this[int id]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(GizmoCap3D cap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(int capHandleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(GizmoCap3D cap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(GizmoCap3D cap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyZoomFactor(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetZoomFactorTransform(GizmoTransform zoomFactorTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Make3DHoverPriorityLowerThan(Priority priority) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Make3DHoverPriorityHigherThan(Priority priority) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVisible(bool visible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<GizmoCap3D> GetRenderSortedCaps(Camera renderCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoCap3DCollection() => throw null;
  }
}
