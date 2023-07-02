// Decompiled with JetBrains decompiler
// Type: RTG.GizmoPlaneSlider2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoPlaneSlider2D : GizmoSlider
  {
    private int _quadIndex;
    private int _circleIndex;
    private int _polygonIndex;
    private QuadShape2D _quad;
    private CircleShape2D _circle;
    private PolygonShape2D _polygon;
    private GizmoQuad2DBorder _quadBorder;
    private GizmoCircle2DBorder _circleBorder;
    private GizmoPolygon2DBorder _polygonBorder;
    private bool _isBorderVisible;
    private bool _isBorderHoverable;
    private GizmoTransform _transform;
    private GizmoDragChannel _dragChannel;
    private IGizmoDragSession _selectedDragSession;
    private GizmoDblAxisOffsetDrag3D _offsetDrag;
    private Vector3 _offsetDragOrigin;
    private GizmoSglAxisRotationDrag3D _rotationDrag;
    private GizmoRotationArc2D _rotationArc;
    private GizmoDblAxisScaleDrag3D _scaleDrag;
    private Vector3 _scaleDragOrigin;
    private Vector3 _scaleAxisRight;
    private Vector3 _scaleAxisUp;
    private int _scaleDragAxisIndexRight;
    private int _scaleDragAxisIndexUp;
    private GizmoPlaneSlider2DControllerData _controllerData;
    private IGizmoPlaneSlider2DController[] _controllers;
    private GizmoPlaneSlider2DSettings _settings;
    private GizmoPlaneSlider2DSettings _sharedSettings;
    private GizmoPlaneSlider2DLookAndFeel _lookAndFeel;
    private GizmoPlaneSlider2DLookAndFeel _sharedLookAndFeel;

    public GizmoPlaneSlider2DSettings Settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoPlaneSlider2DSettings SharedSettings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public GizmoPlaneSlider2DLookAndFeel LookAndFeel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoPlaneSlider2DLookAndFeel SharedLookAndFeel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector2 Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector2 PolyCenter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
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

    public Vector2 Right
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector2 Up
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 OffsetDragOrigin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public GizmoDragChannel DragChannel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 ScaleDragOrigin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int ScaleDragAxisIndexRight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int ScaleDragAxisIndexUp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 TotalDragOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 RelativeDragOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float TotalDragRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RelativeDragRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float TotalDragScaleRight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RelativeDragScaleRight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float TotalDragScaleUp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RelativeDragScaleUp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsBorderVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsBorderHoverable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsDragged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsMoving
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsRotating
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsScaling
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoPlaneSlider2D(Gizmo gizmo, int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBorderVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBorderHoverable(bool isHoverable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetSnapEnabled(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPolyCwPoints(List<Vector2> cwPoints, bool isClosed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MakePolySphereBorder(
      Vector3 sphereCenter,
      float sphereRadius,
      int numPoints,
      Camera camera)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealQuadWidth() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealQuadHeight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetRealQuadSize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealCircleRadius() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetRealExtentPoint(Shape2DExtentPoint extentPt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDragChannel(GizmoDragChannel dragChannel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddTargetTransform(GizmoTransform transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveTargetTransform(GizmoTransform transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel) => throw null;

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
    private void OnGizmoAttemptHandleDragBegin(Gizmo gizmo, int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoHandleDragUpdate(Gizmo gizmo, int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoPostEnabled(Gizmo gizmo) => throw null;
  }
}
