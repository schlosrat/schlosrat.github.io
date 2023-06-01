// Decompiled with JetBrains decompiler
// Type: RTG.GizmoPlaneSlider3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoPlaneSlider3D : GizmoSlider
  {
    private int _quadIndex;
    private int _raTriangleIndex;
    private int _circleIndex;
    private QuadShape3D _quad;
    private RightAngTriangle3D _raTriangle;
    private CircleShape3D _circle;
    private GizmoQuad3DBorder _quadBorder;
    private GizmoRATriangle3DBorder _raTriangleBorder;
    private GizmoCircle3DBorder _circleBorder;
    private bool _isBorderHoverable;
    private bool _isBorderVisible;
    private GizmoTransform _transform;
    private GizmoDragChannel _dragChannel;
    private IGizmoDragSession _selectedDragSession;
    private GizmoDblAxisOffsetDrag3D _dblAxisOffsetDrag;
    private GizmoSglAxisRotationDrag3D _rotationDrag;
    private GizmoRotationArc3D _rotationArc;
    private GizmoDblAxisScaleDrag3D _scaleDrag;
    private int _scaleDragAxisIndexRight;
    private int _scaleDragAxisIndexUp;
    private GizmoPlaneSlider3DControllerData _controllerData;
    private IGizmoPlaneSlider3DController[] _controllers;
    private GizmoPlaneSlider3DSettings _settings;
    private GizmoPlaneSlider3DSettings _sharedSettings;
    private GizmoPlaneSlider3DLookAndFeel _lookAndFeel;
    private GizmoPlaneSlider3DLookAndFeel _sharedLookAndFeel;

    public GizmoPlaneSlider3DSettings Settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoPlaneSlider3DSettings SharedSettings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public GizmoPlaneSlider3DLookAndFeel LookAndFeel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoPlaneSlider3DLookAndFeel SharedLookAndFeel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Plane Plane
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

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

    public Quaternion LocalRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 Right
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Up
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Look
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Normal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoDragChannel DragChannel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
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
    public GizmoPlaneSlider3D(Gizmo gizmo, int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBorderVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBorderHoverable(bool isHoverable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetSnapEnabled(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetZoomFactorTransform(GizmoTransform transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetZoomFactor(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealQuadWidth(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealQuadHeight(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetRealQuadSize(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealCircleRadius(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealRATriXLength(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealRATriYLength(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetRealRATriSize(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AlignToQuadrant(
      GizmoTransform transform,
      PlaneId planeId,
      PlaneQuadrantId quadrantId,
      bool alignXToFirstAxis)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MakeSliderPlane(
      GizmoTransform sliderPlaneTransform,
      PlaneId planeId,
      GizmoLineSlider3D firstAxisSlider,
      GizmoLineSlider3D secondAxisSlider,
      Camera camera)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetQuadCornerPosition(QuadCorner corner) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetQuadCornerPosition(QuadCorner corner, Vector3 cornerPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyZoomFactor(Camera camera) => throw null;

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
    private void OnCanHoverHandle(
      int handleId,
      Gizmo gizmo,
      GizmoHandleHoverData hoverData,
      YesNoAnswer answer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoPostEnabled(Gizmo gizmo) => throw null;
  }
}
