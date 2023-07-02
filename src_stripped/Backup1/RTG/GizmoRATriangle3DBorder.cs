// Decompiled with JetBrains decompiler
// Type: RTG.GizmoRATriangle3DBorder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoRATriangle3DBorder
  {
    private GizmoPlaneSlider3D _planeSlider;
    private GizmoHandle _targetHandle;
    private RightAngTriangle3D _targetTriangle;
    private bool _isVisible;
    private bool _isHoverable;
    private int _borderTriangleIndex;
    private RightAngTriangle3D _borderTriangle;
    private GizmoRATriangle3DBorderControllerData _controllerData;
    private IGizmoRATriangle3DBorderController[] _controllers;

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
    public GizmoRATriangle3DBorder(
      GizmoPlaneSlider3D planeSlider,
      GizmoHandle targetHandle,
      RightAngTriangle3D targetRiangle)
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
    public void OnTriangleShapeChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Render(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoPreUpdateBegin(Gizmo gizmo) => throw null;
  }
}
