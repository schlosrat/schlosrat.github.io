// Decompiled with JetBrains decompiler
// Type: RTG.GizmoLineSlider3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoLineSlider3D : GizmoSlider
  {
    private SegmentShape3D _segment;
    private BoxShape3D _box;
    private CylinderShape3D _cylinder;
    private int _segmentIndex;
    private int _boxIndex;
    private int _cylinderIndex;
    private IGizmoLineSlider3DController[] _controllers;
    private GizmoLineSlider3DControllerData _controllerData;
    private GizmoDragChannel _dragChannel;
    private GizmoSglAxisOffsetDrag3D _offsetDrag;
    private GizmoSglAxisRotationDrag3D _rotationDrag;
    private GizmoRotationArc3D _rotationArc;
    private GizmoSglAxisScaleDrag3D _scaleDrag;
    private int _scaleDragAxisIndex;
    private List<GizmoScalerHandle> _scalerHandles;
    private IGizmoDragSession _selectedDragSession;
    private GizmoCap3D _cap3D;
    private GizmoTransform _transform;
    private GizmoTransformAxisMap3D _directionAxisMap;
    private GizmoTransformAxisMap3D _dragRotationAxisMap;
    private GizmoOverrideColor _overrideColor;
    private GizmoLineSlider3DSettings _settings;
    private GizmoLineSlider3DSettings _sharedSettings;
    private GizmoLineSlider3DLookAndFeel _lookAndFeel;
    private GizmoLineSlider3DLookAndFeel _sharedLookAndFeel;

    public Vector3 Direction
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 DragRotationAxis
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int ScaleDragAxisIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 StartPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public GizmoDragChannel DragChannel
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

    public bool Is3DCapVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool Is3DCapHoverable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int Cap3DHandleId
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

    public GizmoOverrideColor OverrideColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoOverrideColor Cap3DOverrideColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoLineSlider3DSettings Settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoLineSlider3DSettings SharedSettings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public GizmoLineSlider3DLookAndFeel LookAndFeel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoLineSlider3DLookAndFeel SharedLookAndFeel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoLineSlider3D(Gizmo gizmo, int handleId, int capHandleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsScalerHandleRegistered(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsScalerHandleRegistered(int handleId, int scaleDragAxisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterScalerHandle(int handleId, IEnumerable<int> scaleDragAxisIndices) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterScalerHandle(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetSnapEnabled(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set3DCapVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set3DCapHoverable(bool isHoverable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetZoomFactorTransform(GizmoTransform transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetZoomFactor(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetRealDirection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealSizeAlongDirection(Camera camera, Vector3 direction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealLength(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealLengthWith3DCap(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetRealEndPosition(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetRealEndPositionWith3DCap(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealBoxHeight(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealBoxDepth(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRealCylinderRadius(float zoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MapDirection(int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MapDragRotationAxis(GizmoTransform mapTransform, int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnmapDragRotationAxis() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDirection(Vector3 directionAxis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDragRotationAxis(Vector3 rotationAxis) => throw null;

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
    private void OnGizmoAttemptHandleDragBegin(Gizmo gizmo, int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTransformChanged(GizmoTransform transform, GizmoTransform.ChangeData changeData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoHandleHoverEnter(Gizmo gizmo, int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoPostEnabled(Gizmo gizmo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoPostDisabled(Gizmo gizmo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoHandleHoverExit(Gizmo gizmo, int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupSharedLookAndFeel() => throw null;
  }
}
