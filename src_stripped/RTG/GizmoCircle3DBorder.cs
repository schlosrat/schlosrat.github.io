// Decompiled with JetBrains decompiler
// Type: RTG.GizmoCircle3DBorder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoCircle3DBorder
  {
    private GizmoPlaneSlider3D _planeSlider;
    private GizmoHandle _targetHandle;
    private CircleShape3D _targetCircle;
    private bool _isVisible;
    private bool _isHoverable;
    private int _borderCircleIndex;
    private int _borderTorusIndex;
    private int _borderCylTorusIndex;
    private CircleShape3D _borderCircle;
    private TorusShape3D _borderTorus;
    private CylTorusShape3D _borderCylTorus;
    private GizmoCircle3DBorderControllerData _controllerData;
    private IGizmoCircle3DBorderController[] _controllers;

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
    public GizmoCircle3DBorder(
      GizmoPlaneSlider3D planeSlider,
      GizmoHandle targetHandle,
      CircleShape3D targetCircle)
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
    public float GetRealTorusThickness(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealCylTorusWidth(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealCylTorusHeight(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCircleShapeChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Render(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoPreUpdateBegin(Gizmo gizmo) => throw null;
  }
}
