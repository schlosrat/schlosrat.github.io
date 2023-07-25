// Decompiled with JetBrains decompiler
// Type: RTG.GizmoCap3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoCap3D : GizmoCap
  {
    private int _coneIndex;
    private ConeShape3D _cone;
    private int _pyramidIndex;
    private PyramidShape3D _pyramid;
    private int _boxIndex;
    private BoxShape3D _box;
    private int _sphereIndex;
    private SphereShape3D _sphere;
    private int _trPrismIndex;
    private TriangPrismShape3D _trPrism;
    private GizmoCap3DControllerData _controllerData;
    private IGizmoCap3DController[] _controllers;
    private GizmoTransform _transform;
    private GizmoOverrideColor _overrideColor;
    private GizmoCap3DLookAndFeel _lookAndFeel;
    private GizmoCap3DLookAndFeel _sharedLookAndFeel;

    public Vector3 Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Quaternion Rotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public GizmoOverrideColor OverrideColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IGizmoDragSession DragSession
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public GizmoCap3DLookAndFeel LookAndFeel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoCap3DLookAndFeel SharedLookAndFeel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoCap3D(Gizmo gizmo, int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterTransformAsDragTarget(IGizmoDragSession dragSession) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterTransformAsDragTarget(IGizmoDragSession dragSession) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AlignTransformAxis(int axisIndex, AxisSign axisSign, Vector3 axis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetZoomFactorTransform(GizmoTransform transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CapSlider3D(Vector3 sliderDirection, Vector3 sliderEndPt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CapSlider3DInvert(Vector3 sliderDirection, Vector3 sliderEndPt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetSliderAlignedRealLength(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetZoomFactor(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealConeHeight(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealConeRadius(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealPyramidWidth(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealPyramidDepth(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealPyramidHeight(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealBoxWidth(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealBoxHeight(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealBoxDepth(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetRealBoxSize(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealSphereRadius(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealTriPrismWidth(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealTriPrismHeight(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealTriPrismDepth(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyZoomFactor(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Render(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Refresh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnVisibilityStateChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnHoverableStateChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoPreUpdateBegin(Gizmo gizmo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTransformChanged(GizmoTransform transform, GizmoTransform.ChangeData changeData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoPostEnabled(Gizmo gizmo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoPostDisabled(Gizmo gizmo) => throw null;
  }
}
