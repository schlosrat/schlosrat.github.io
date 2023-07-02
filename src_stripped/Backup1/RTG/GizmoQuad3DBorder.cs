// Decompiled with JetBrains decompiler
// Type: RTG.GizmoQuad3DBorder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoQuad3DBorder
  {
    private GizmoPlaneSlider3D _planeSlider;
    private GizmoHandle _targetHandle;
    private QuadShape3D _targetQuad;
    private bool _isVisible;
    private bool _isHoverable;
    private int _borderQuadIndex;
    private QuadShape3D _borderQuad;
    private int _topBoxIndex;
    private BoxShape3D _topBox;
    private int _rightBoxIndex;
    private BoxShape3D _rightBox;
    private int _bottomBoxIndex;
    private BoxShape3D _bottomBox;
    private int _leftBoxIndex;
    private BoxShape3D _leftBox;
    private int _topLeftBoxIndex;
    private BoxShape3D _topLeftBox;
    private int _topRightBoxIndex;
    private BoxShape3D _topRightBox;
    private int _bottomRightBoxIndex;
    private BoxShape3D _bottomRightBox;
    private int _bottomLeftBoxIndex;
    private BoxShape3D _bottomLeftBox;
    private List<int> _sortedBoxIndices;
    private GizmoQuad3DBorderControllerData _controllerData;
    private IGizmoQuad3DBorderController[] _controllers;

    public bool IsVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsHoverable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Gizmo Gizmo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoQuad3DBorder(
      GizmoPlaneSlider3D planeSlider,
      GizmoHandle targetHandle,
      QuadShape3D targetQuad)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetHoverable(bool isHoverable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetZoomFactor(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealBoxHeight(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealBoxDepth(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnQuadShapeChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Render(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoPreUpdateBegin(Gizmo gizmo) => throw null;
  }
}
