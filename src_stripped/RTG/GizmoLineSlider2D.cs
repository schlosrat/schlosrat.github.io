// Decompiled with JetBrains decompiler
// Type: RTG.GizmoLineSlider2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoLineSlider2D : GizmoSlider
  {
    private SegmentShape2D _segment;
    private QuadShape2D _quad;
    private int _segmentIndex;
    private int _quadIndex;
    private GizmoDragChannel _dragChannel;
    private GizmoSglAxisOffsetDrag3D _offsetDrag;
    private Vector3 _offsetDragOrigin;
    private GizmoSglAxisRotationDrag3D _rotationDrag;
    private GizmoRotationArc2D _rotationArc;
    private GizmoSglAxisScaleDrag3D _scaleDrag;
    private Vector3 _scaleDragOrigin;
    private Vector3 _scaleAxis;
    private int _scaleDragAxisIndex;
    private IGizmoDragSession _selectedDragSession;
    private GizmoCap2D _cap2D;
    private GizmoTransform _transform;
    private GizmoTransformAxisMap2D _directionAxisMap;
    private GizmoOverrideColor _overrideFillColor;
    private GizmoOverrideColor _overrideBorderColor;
    private GizmoLineSlider2DControllerData _controllerData;
    private IGizmoLineSlider2DController[] _controllers;
    private GizmoLineSlider2DSettings _settings;
    private GizmoLineSlider2DSettings _sharedSettings;
    private GizmoLineSlider2DLookAndFeel _lookAndFeel;
    private GizmoLineSlider2DLookAndFeel _sharedLookAndFeel;

    public Quaternion Rotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RotationDegrees
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector2 StartPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector2 Direction
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 OffsetDragOrigin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 ScaleDragOrigin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int ScaleDragAxisIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int Cap2DHandleId
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

    public bool Is2DCapVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool Is2DCapHoverable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
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

    public float TotalDragScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RelativeDragScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoOverrideColor OverrideFillColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoOverrideColor OverrideBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoLineSlider2DSettings Settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoLineSlider2DSettings SharedSettings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public GizmoLineSlider2DLookAndFeel LookAndFeel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoLineSlider2DLookAndFeel SharedLookAndFeel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoLineSlider2D(Gizmo gizmo, int handleId, int capHandleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetSnapEnabled(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set2DCapVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set2DCapHoverable(bool isHoverable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetRealDirection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealLength() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetRealEndPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealBoxThickness() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MapDirection(int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDirection(Vector2 directionAxis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddTargetTransform(GizmoTransform transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveTargetTransform(GizmoTransform transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDragChannel(GizmoDragChannel dragChannel) => throw null;

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
    private void OnGizmoAttemptHandleDragBegin(Gizmo gizmo, int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTransformChanged(GizmoTransform transform, GizmoTransform.ChangeData changeData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoHandleHoverEnter(Gizmo gizmo, int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoHandleHoverExit(Gizmo gizmo, int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoHandleDragUpdate(Gizmo gizmo, int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupSharedLookAndFeel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoPostEnabled(Gizmo gizmo) => throw null;
  }
}
