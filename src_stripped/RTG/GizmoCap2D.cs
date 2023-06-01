// Decompiled with JetBrains decompiler
// Type: RTG.GizmoCap2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoCap2D : GizmoCap
  {
    private int _quadIndex;
    private QuadShape2D _quad;
    private int _circleIndex;
    private CircleShape2D _circle;
    private int _arrowIndex;
    private ConeShape2D _arrow;
    private GizmoTransform _transform;
    private GizmoOverrideColor _overrideFillColor;
    private GizmoOverrideColor _overrideBorderColor;
    private GizmoCap2DControllerData _controllerData;
    private IGizmoCap2DController[] _controllers;
    private GizmoCap2DLookAndFeel _lookAndFeel;
    private GizmoCap2DLookAndFeel _sharedLookAndFeel;

    public Vector2 Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Quaternion Rotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RotationDegrees
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public GizmoOverrideColor OverrideFillColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoOverrideColor OverrideBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IGizmoDragSession DragSession
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public GizmoCap2DLookAndFeel LookAndFeel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoCap2DLookAndFeel SharedLookAndFeel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoCap2D(Gizmo gizmo, int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterTransformAsDragTarget(IGizmoDragSession dragSession) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterTransformAsDragTarget(IGizmoDragSession dragSession) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AlignTransformAxis(int axisIndex, AxisSign axisSign, Vector2 axis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealQuadWidth() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealQuadHeight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealCircleRadius() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealArrowHeight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealArrowBaseRadius() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CapSlider2D(Vector2 sliderDirection, Vector2 sliderEndPt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CapSlider2DInvert(Vector2 sliderDirection, Vector2 sliderEndPt) => throw null;

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
  }
}
